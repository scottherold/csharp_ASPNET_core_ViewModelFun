using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            //Creates a string and returns it to the "Index.cshtml" view
            string message = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                In lobortis quam libero, ut aliquet felis dapibus in. Nunc 
                                tristique hendrerit porta. Pellentesque id dui id ipsum pulvinar 
                                cursus sit amet et quam. Sed non lectus aliquam, accumsan tortor 
                                eget, volutpat justo. Nam luctus arcu nec ex tincidunt ullamcorper. 
                                
                                Aenean convallis tortor ac ultricies condimentum. Ut sollicitudin 
                                est eu felis pretium porttitor. Nullam in eleifend diam. Ut cursus 
                                ipsum nulla, non lobortis quam blandit a. Nam efficitur odio ut 
                                convallis vehicula. Morbi felis nisl, venenatis ut sollicitudin nec, 
                                tristique a turpis. Aenean posuere semper sem eu sodales. Phasellus 
                                quis elit vitae arcu efficitur sagittis. In tortor nulla, placerat 
                                eget nisi non, fermentum rhoncus erat. Fusce non libero dolor. 
                                Aliquam vel nisi risus. Vestibulum ante ipsum primis in faucibus 
                                orci luctus et ultrices posuere cubilia Curae; Curabitur enim erat, 
                                pretium sed libero quis, finibus maximus felis.";
            
            return View("Index", message);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            // Creates an integer array and returns it to the "Numbers.cshtml" view
            int[] intArr = {1, 2, 3, 10, 43, 5};
            
            return View("Numbers", intArr);
        }
        [HttpGet("users")]

        // Creates 5 User objects to be used for the model user list
        public ViewResult Users()
        {
            Models.User newUser1 = new Models.User()
            {
                FirstName = "Moose",
                LastName = "Phillips",
            };
            Models.User newUser2 = new Models.User()
            {
                FirstName = "Sarah",
                LastName = "",
            };
            Models.User newUser3 = new Models.User()
            {
                FirstName = "Jerry",
                LastName = ""
            };

            Models.User newUser4 = new Models.User()
            {
                FirstName = "Rene",
                LastName = "Ricky",
            };
            Models.User newUser5 = new Models.User()
            {
                FirstName = "Barbarah",
                LastName = "",
            };

            // creates the model User list, and returns that lisy to the "Users.cshtml" view.
            List<Models.User> users = new List<Models.User>();
            users.Add(newUser1);
            users.Add(newUser2);
            users.Add(newUser3);
            users.Add(newUser4);
            users.Add(newUser5);
            return View("Users", users);
        }
        [HttpGet("user")]
        public IActionResult IUser()
        {

            // Creates a User model and returns it to the "User.cshtml" view.
            Models.User newUser = new Models.User()
            {
                FirstName = "Moose",
                LastName = "Phillips",
            };
            return View("User", newUser);
        }
    }
}