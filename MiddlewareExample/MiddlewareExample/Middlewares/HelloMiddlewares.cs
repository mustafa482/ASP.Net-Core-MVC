using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample.Middlewares
{
    
    public class HelloMiddlewares
    {
        RequestDelegate _next;

        public HelloMiddlewares(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("AssalamunAleykum");
            await _next.Invoke(context);
            Console.WriteLine("AleykumSalam");
        }

    }
}
