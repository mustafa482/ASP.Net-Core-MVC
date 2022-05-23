using Dependency_Injection.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Dependency_Injection
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection();//built -in IoC
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            ServiceProvider provider = services.BuildServiceProvider();//provider
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();

        }


    }
}
