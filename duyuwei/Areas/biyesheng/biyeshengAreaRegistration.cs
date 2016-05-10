using System.Web.Http;
using System.Web.Mvc;

namespace duyuwei.Areas.biyesheng
{
    public class biyeshengAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "biyesheng";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "biyesheng_default",
                "biyesheng/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
