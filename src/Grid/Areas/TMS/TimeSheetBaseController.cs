﻿using System.Web.Mvc;
using Grid.Infrastructure;

namespace Grid.Areas.TMS
{
    public class TimeSheetBaseController: GridBaseController
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            ViewBag.ApplicationTitle = "Timesheets";
        }
    }
}