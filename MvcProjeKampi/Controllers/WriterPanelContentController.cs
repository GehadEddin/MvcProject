﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        // GET: WriterPanelContent
        public ActionResult GetContentByWriter()
        {
            var contentvalue = cm.GetListByWriter();
            return View(contentvalue);
        }
    }
}