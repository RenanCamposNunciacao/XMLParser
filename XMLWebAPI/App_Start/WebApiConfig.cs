﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace XMLWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            config.Formatters.XmlFormatter.UseXmlSerializer = true;

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{id}",
                defaults: new { id = RouteParameter.Optional, controller = "Default", action = "Default"}
            );
        }
    }
}
