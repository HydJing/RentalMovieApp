using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalMovieApp.Startup))]
namespace RentalMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
