using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentData;
using duyuwei.Areas.biyesheng.Models;

namespace duyuwei.Areas.biyesheng.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /biyesheng/login/
        [HttpGet]
        public ActionResult Index(string msg="")
        {
            ViewBag.msg = msg;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string xh,string csrq)
        {
            IDbContext db = DBhelper.QueryDB();
            string sqlStr = "select csrq from ziyuan where xh=" + xh;
            string dbcsrq = db.Sql(sqlStr).QuerySingle<string>();
            if (dbcsrq==null)
            {
                return Redirect("/biyesheng/login/index?msg=学号错误，请输入完整学号！如：120050104");
            }
            dbcsrq = dbcsrq.Substring(2);
            if (csrq == dbcsrq)
            {
                Session["LoginUser"] = xh;
                return Redirect("/biyesheng/index/index");
            }
            else
            {
                return Redirect("/biyesheng/login/index?msg=生日错误，请输入6位生日！如：930405");
            }
            
        }

        public ActionResult Logout()
        {
            Session["LoginUser"] = null;
            return Redirect("/biyesheng/login/index");
        }

        public ActionResult Aboutme()
        {
            return View();
        }

    }
}
