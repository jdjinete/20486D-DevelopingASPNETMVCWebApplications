﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSyntaxExample.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string bread = "Bread";
            string rice = "Rice";
            return View();
        }
    }


}