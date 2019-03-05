using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolBook.Startup))]
namespace SchoolBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
