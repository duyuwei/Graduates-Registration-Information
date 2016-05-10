using duyuwei.Areas.zuiMeiJiaoShi.Models;
using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace duyuwei.Areas.zuiMeiJiaoShi.Controllers
{
    public class ycjyController : Controller
    {
        //
        // GET: /zuiMeiJiaoShi/ycjy/

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["LoginUser"] == null)
            {
                return Redirect("/zuiMeiJiaoShi/login/Index");
            }
            string xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            string strsql = "select isSuggested from zmjs_studentsInfo where xh='" + xh + "'";
            string isSuggested = db.Sql(strsql).QuerySingle<string>();
            if (!string.IsNullOrEmpty(isSuggested))
            {
                return Redirect("/zuiMeiJiaoShi/login/Index?msg=你已填写过建议，不能再次填写！&type=ycjy");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(zmjs_suggest Info)
        {
            string xh = Session["LoginUser"].ToString();
            Info.title = Info.title.Trim();
            Info.suggest = Info.suggest.Trim();
            IDbContext db = DBhelper.QueryDB();
            db.Update("zmjs_studentsInfo")
                .Column("isSuggested", "yes")
                .Where("xh", xh)
                .Execute();
            db.Insert<zmjs_suggest>("zmjs_suggest", Info).AutoMap(x => x.ID).Execute();
            return View("success");
        }

    }
}
