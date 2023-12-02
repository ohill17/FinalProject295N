using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class GameController : Controller
    {
       
        public IActionResult Index()
        {

            return View();
        }

        
    }

}