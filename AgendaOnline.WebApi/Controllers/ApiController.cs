using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaOnline.WebApi.Controllers
{    
    public abstract class ApiController : ControllerBase
    {
        //protected bool IsValidOperation()
        //{
        //    return ("Erro");
        //}

        //protected new IActionResult Response(object result = null)
        //{
        //    if (IsValidOperation())
        //    {
        //        return Ok(new
        //        {
        //            success = true,
        //            data = result
        //        });
        //    }

        //    return BadRequest(new
        //    {
        //        success = false,
        //        errors = _notifications.GetNotifications().Select(n => n.Value)
        //    });
        //}
    }
}