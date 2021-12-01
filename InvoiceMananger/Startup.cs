using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvoiceMananger.Startup))]
namespace InvoiceMananger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
