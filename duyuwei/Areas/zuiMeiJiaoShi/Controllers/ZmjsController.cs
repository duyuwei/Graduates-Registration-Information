using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentData;
using duyuwei.Areas.zuiMeiJiaoShi.Models;

namespace duyuwei.Areas.zuiMeiJiaoShi.Controllers
{
    public class ZmjsController : Controller
    {
        //
        // GET: /biyesheng/Zmjs/
        

        [HttpGet]
        public ActionResult Index()
        {
            if ( Session["LoginUser"]==null)
            {
                return Redirect("/zuiMeiJiaoShi/login/Index");
            }
            string xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            string strsql = "select teacher from zmjs_studentsInfo where xh='" + xh + "'";
            string teacher = db.Sql(strsql).QuerySingle<string>();
            if (!string.IsNullOrEmpty(teacher))
            {
                return Redirect("/zuiMeiJiaoShi/login/Index?msg=你已经参与过投票了，不能再次投票！&type=zmjs");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(zmjs_studentsInfo Info) 
        {
            Info.xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            db.Update("zmjs_studentsInfo")
                .Column("teacher", Info.teacher.Trim())
                .Column("reason", Info.reason.Trim())
                .Where("xh", Info.xh)
                .Execute();
            return View("success");
        }


    }
}
