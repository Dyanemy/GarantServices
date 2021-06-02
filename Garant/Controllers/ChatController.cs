using Garant.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Garant.Controllers
{
    
    [Authorize]
    public class ChatController : Controller
    {

        private ApplicationContext db;

        public ChatController(ApplicationContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            // Current user
            User user = db.Users.FirstOrDefault(user => user.UserName == User.Identity.Name);

            ViewBag.userName = user.UserName;


            // Dialog with this user
            List<Dialog> userDialogs = db.Dialogs.Where(dialog => dialog.ClientId == user.Id || dialog.WorkerId == user.Id).ToList();
            
            foreach(Dialog dialog in userDialogs)
            {
                if(user.Id == dialog.ClientId)
                {
                    dialog.AnotherUser = db.Users.FirstOrDefault(user => user.Id == dialog.WorkerId);
                }
                else
                {
                    dialog.AnotherUser = db.Users.FirstOrDefault(user => user.Id == dialog.ClientId);
                }
            }

            return View(userDialogs);
        }

        [HttpGet("{controller}/{id}")]
        public IActionResult Index(int id)
        {
            // Current user
            User user = db.Users.FirstOrDefault(user => user.UserName == User.Identity.Name);

            Dialog dialog = db.Dialogs.FirstOrDefault(dialog => dialog.id == id);

            if (user.Id == dialog.ClientId)
            {
                dialog.AnotherUser = db.Users.FirstOrDefault(user => user.Id == dialog.WorkerId);
            }
            else
            {
                dialog.AnotherUser = db.Users.FirstOrDefault(user => user.Id == dialog.ClientId);
            }


            if (dialog == null)
            {
                return NotFound();
            }

            if (dialog.ClientId != user.Id && dialog.WorkerId != user.Id)
            {
                return Json("You don't have premission");
            }


            List<Message> messages = db.Messages.Where(message => message.DialogID == id).ToList();

            foreach(Message message in messages)
            {
                message.Sender = db.Users.FirstOrDefault(user => user.Id == message.SenderID);
            }

            DialogViewModel dialogViewModel = new DialogViewModel()
            {
                dialog = dialog,
                Messages = messages
            };

            return View("Dialog", dialogViewModel);
        }


        public IActionResult SendMessage(string text, int dialogID)
        {
            // Current user
            User user = db.Users.FirstOrDefault(user => user.UserName == User.Identity.Name);

            Dialog dialog = db.Dialogs.FirstOrDefault(dialog => dialog.id == dialogID);

            if(dialog == null)
            {
                return NotFound();
            }

            if(dialog.ClientId != user.Id && dialog.WorkerId != user.Id)
            {
                return Json("You don't have premission");
            }

            Message message = new Message()
            {
                Date = DateTime.Now,
                Text = text,
                SenderID = user.Id,
                DialogID = dialogID
            };

            db.Messages.Add(message);

            db.SaveChanges();

            return RedirectToAction("Index", "Chat"); 

        }

    }
}
