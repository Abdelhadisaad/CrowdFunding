using Crowd_Funding.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowd_Funding.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login(UsersModel usersModel)
        {
            if (usersModel.email == "" && usersModel.password == "")
            {
                return View("Home", usersModel);

            } else
            {
                return View("index"); 
            }
        }
    }
}
