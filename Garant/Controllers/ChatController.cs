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
            List<Dialog> userDialogs = db.Dialogs.Where(dialog => dialog.Client.Id == user.Id || dialog.Worker.Id == user.Id).ToList();

            List<DialogViewModel> dialogModel = new List<DialogViewModel>();
            
            foreach(Dialog dialog in userDialogs)
            {
                List<Message> messages = db.Messages.Where(message => message.DialogID == dialog.id).ToList();

                dialogModel.Add(new DialogViewModel() { dialog = dialog, Messages = messages });
            }

            return View(dialogModel);
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            // Current user
            User user = db.Users.FirstOrDefault(user => user.UserName == User.Identity.Name);

            Dialog dialog = db.Dialogs.FirstOrDefault(dialog => dialog.id == id);


            if (dialog == null)
            {
                return NotFound();
            }

            if (dialog.Client.Id != user.Id && dialog.Worker.Id != user.Id)
            {
                return Json("You don't have premission");
            }



            List<Message> messages = db.Messages.Where(message => message.DialogID == id).ToList();

            DialogViewModel dialogViewModel = new DialogViewModel()
            {
                dialog = dialog,
                Messages = messages
            };

            return View(dialogViewModel);
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

            if(dialog.Client.Id != user.Id && dialog.Worker.Id != user.Id)
            {
                return Json("You don't have premission");
            }

            Message message = new Message()
            {
                Date = DateTime.Now,
                Text = text,
                Sender = user,
                DialogID = dialogID
            };

            db.Messages.Add(message);

            db.SaveChanges();

            return RedirectToAction("Index", "Chat"); 

        }

    }
}
