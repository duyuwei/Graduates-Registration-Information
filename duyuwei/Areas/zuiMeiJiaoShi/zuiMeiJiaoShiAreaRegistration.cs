using System.Web.Mvc;

namespace duyuwei.Areas.zuiMeiJiaoShi
{
    public class zuiMeiJiaoShiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "zuiMeiJiaoShi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "zuiMeiJiaoShi_default",
                "zuiMeiJiaoShi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
