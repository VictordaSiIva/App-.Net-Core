﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoredOfBuild.Web.Models;

namespace StoredOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
         public IActionResult CreateOrEdit(int id)
        {
            return View();
        }

    }
}
