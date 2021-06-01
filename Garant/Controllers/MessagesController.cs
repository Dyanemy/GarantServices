//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.SignalR;
//using System.Text.RegularExpressions;
//using Garant.Models;

//namespace Garant.Controllers
//{
//    [Authorize]
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MessagesController : ControllerBase
//    {
//        private readonly ApplicationContext _context;
//        private readonly IMapper _mapper;
//        private readonly IHubContext<ChatHub> _hubContext;

//        public MessagesController(ApplicationContext context,
//            IMapper mapper,
//            IHubContext<ChatHub> hubContext)
//        {
//            _context = context;
//            _mapper = mapper;
//            _hubContext = hubContext;
//        }


//        [HttpGet("Room/{roomName}")]
//        public IActionResult GetMessages(string roomName)
//        {
//            var room = _context.Rooms.FirstOrDefault(r => r.Name == roomName);
//            if (room == null)
//                return BadRequest();

//            var messages = _context.Messages.Where(m => m.ToRoomId == room.Id)
//                .Include(m => m.FromUser)
//                .Include(m => m.ToRoom)
//                .OrderByDescending(m => m.Timestamp)
//                .Take(20)
//                .AsEnumerable()
//                .Reverse()
//                .ToList();

//            var messagesViewModel = _mapper.Map<IEnumerable<Message>, IEnumerable<MessageViewModel>>(messages);

//            return Ok(messagesViewModel);
//        }

//        [HttpPost]
//        public async Task<ActionResult<Message>> Create(MessageViewModel messageViewModel)
//        {
//            var user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
//            var room = _context.Rooms.FirstOrDefault(r => r.Name == messageViewModel.Room);
//            if (room == null)
//                return BadRequest();

//            var msg = new Message()
//            {
//                Content = Regex.Replace(messageViewModel.Content, @"(?i)<(?!img|a|/a|/img).*?>", string.Empty),
//                FromUser = user,
//                ToRoom = room,
//                Timestamp = DateTime.Now
//            };

//            _context.Messages.Add(msg);
//            await _context.SaveChangesAsync();

       
//            var createdMessage = _mapper.Map<Message, MessageViewModel>(msg);
//            await _hubContext.Clients.Group(room.Name).SendAsync("newMessage", createdMessage);

//            return CreatedAtAction(nameof(Get), new { id = msg.Id }, createdMessage);
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            var message = await _context.Messages
//                .Include(u => u.FromUser)
//                .Where(m => m.Id == id && m.FromUser.UserName == User.Identity.Name)
//                .FirstOrDefaultAsync();

//            if (message == null)
//                return NotFound();

//            _context.Messages.Remove(message);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }
//    }
//}
