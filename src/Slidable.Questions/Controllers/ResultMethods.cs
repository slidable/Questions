﻿using Microsoft.AspNetCore.Mvc;

namespace Slidable.Questions.Controllers
{
    public static class ResultMethods
    {
        public static IActionResult Ok(object value)
        {
            return new OkObjectResult(value);
        }

        public static ActionResult NotFound()
        {
            return new NotFoundResult();
        }

        public static IActionResult CreatedAtAction(string actionName, string controllerName, object routeValues,
            object value)
        {
            return new CreatedAtActionResult(actionName, controllerName, routeValues, value);
        }

        public static IActionResult Accepted()
        {
            return new AcceptedResult();
        }
    }
}