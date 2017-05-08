using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;


namespace Texter.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //To view all the messages: it will be a standard GET request.
        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        } 

        //To Send a message:  this will be a POST request.
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }
    }
}
