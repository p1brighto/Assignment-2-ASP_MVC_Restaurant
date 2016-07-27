using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_2_ASP_MVC_Restaurant.Startup))]
namespace Assignment_2_ASP_MVC_Restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
