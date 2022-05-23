using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MiddlewareExample.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddlewares>();
        }
    }
}
