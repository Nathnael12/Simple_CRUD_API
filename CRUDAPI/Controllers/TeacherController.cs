﻿using Microsoft.AspNetCore.Mvc;

namespace CRUDAPI.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
