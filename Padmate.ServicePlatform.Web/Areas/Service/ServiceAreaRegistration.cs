﻿using System.Web.Mvc;

namespace Padmate.ServicePlatform.Web.Areas.Service
{
    public class ServiceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Service";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Service_default",
                "Service/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[]{ "Padmate.ServicePlatform.Web.Controllers.Service"}
            );
        }
    }
}