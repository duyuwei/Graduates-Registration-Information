using duyuwei.Areas.zuiMeiJiaoShi.Models;
using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace duyuwei.Areas.zuiMeiJiaoShi.Controllers
{
    public class ycfxController : Controller
    {
        //
        // GET: /zuiMeiJiaoShi/ycfx/

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["LoginUser"] == null)
            {
                return Redirect("/zuiMeiJiaoShi/login/Index");
            }
            string xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            string strsql = "select share from zmjs_studentsInfo where xh='" + xh + "'";
            string teacher = db.Sql(strsql).QuerySingle<string>();
            if (!string.IsNullOrEmpty(teacher))
            {
                return Redirect("/zuiMeiJiaoShi/login/Index?msg=你已经参与过“最想说的话”活动了！&type=ycfx");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(zmjs_studentsInfo Info)
        {
            Info.xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            db.Update("zmjs_studentsInfo")
                .Column("share", Info.share.Trim())
                .Where("xh", Info.xh)
                .Execute();
            return View("success");
        }

    }
}
