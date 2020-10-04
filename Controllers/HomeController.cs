using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers     
{
    public class HomeController : Controller   
    {
        
        [HttpGet("")]      
        
        public IActionResult Index()
        {
            string Messages = "It’s time to close the curtains, snuggle up with Ted, and be transported to Yorkshire. Award-winning storyteller, Danyah Miller will be delighting your family with tales inspired by her Yorkshire childhood. Perfect for little ears, 4 – 10 years old.";
            return View("Index", Messages);
        }

        [HttpGet("numbers")]

        public IActionResult Numbers()
        {
            int[] Numbers ={1,2,3,10,43,5};
            return View("Numbers", Numbers);
        }

        [HttpGet("user")]
        public IActionResult OneUser()
        {
            User MyUser = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("OneUser", MyUser);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> AllUsers = new List<User>();
            AllUsers.Add(new User(){FirstName = "Mooser", LastName = "Phillips"});
            AllUsers.Add(new User(){FirstName = "Rene", LastName = "Ricky"});
            AllUsers.Add(new User(){FirstName = "Bar", LastName = "Barah"});
        
            return View("Users", AllUsers);
        }
    }
}
