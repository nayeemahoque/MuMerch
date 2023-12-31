﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Auth
{
    public class EmployeeAccess: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.Session["UserType"];
            if (user.Equals("Employee")) return true;
            httpContext.Response.StatusCode = 401;
            httpContext.Response.Redirect("/Auth/Login");
            return false;
        }
    }
}