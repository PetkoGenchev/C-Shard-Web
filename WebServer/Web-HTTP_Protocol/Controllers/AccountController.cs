﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_HTTP_Protocol.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            this.Response.Cookies.Append("Authentication", "Ivaylo");

            return View();
        }
    }
}
