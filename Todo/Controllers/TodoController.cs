﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        //
        // GET: /Todo/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update(int val)
        {
            return View(val);
        }
    }
}
