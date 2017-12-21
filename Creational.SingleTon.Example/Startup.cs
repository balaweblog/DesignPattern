using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Creational.SingleTon.Example.Startup))]
namespace Creational.SingleTon.Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
