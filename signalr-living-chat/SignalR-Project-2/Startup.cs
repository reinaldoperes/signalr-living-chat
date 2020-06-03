using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR_Project_2.Startup))]

namespace SignalR_Project_2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<MyConnection>("/echo");
        }
    }
}
