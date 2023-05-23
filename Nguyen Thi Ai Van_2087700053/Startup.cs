using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nguyen_Thi_Ai_Van_2087700053.Startup))]
namespace Nguyen_Thi_Ai_Van_2087700053
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
