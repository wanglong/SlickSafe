﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlickOne.WebUtility;

namespace SlickSafe.Web.Controllers.Mvc
{
    /// <summary>
    /// task controller
    /// </summary>
    public class TaskController : MvcAuthControllerBase
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }
    }
}