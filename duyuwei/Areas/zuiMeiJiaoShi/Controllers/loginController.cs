using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentData;
using duyuwei.Areas.zuiMeiJiaoShi.Models;

namespace duyuwei.Areas.zuiMeiJiaoShi.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /biyesheng/login/
        [HttpGet]
        public ActionResult Index(string msg="",string type="")
        {
            if (type=="zmjs")
            {
                ViewBag.title = "登陆—最美教师评选";
            }
            else if (type == "ycjy")
            {
                ViewBag.title = "登陆—为母校发展建言献策";
            }
            else if (type=="ycfx")
            {
                ViewBag.title = "登陆—我最想和学弟学妹说的话";
            }
            else 
            {
                return Redirect("http://ziyuan.hebeu.edu.cn");
            }
            ViewBag.msg = msg;
            ViewBag.type = type;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string xh,string csrq,string type="")
        {
            IDbContext db = DBhelper.QueryDB();
            string sqlStr = "select sfzh from zmjs_studentsInfo where xh='" + xh + "'";
            string dbcsrq = db.Sql(sqlStr).QuerySingle<string>();
            if (dbcsrq==null)
            {
                return Redirect("/zuiMeiJiaoShi/login/index?msg=学号错误，请输入完整学号！如：120050104&type=" + type);
            }
            dbcsrq = dbcsrq.Substring(8, 6);
            if (csrq == dbcsrq)
            {
                Session["LoginUser"] = xh;
                if (type=="zmjs")
                {
                    return Redirect("/zuiMeiJiaoShi/Zmjs/index");
                }
                else if (type=="ycjy")
                {
                    return Redirect("/zuiMeiJiaoShi/ycjy/index");
                }
                else if (type=="ycfx")
                {
                    return Redirect("/zuiMeiJiaoShi/ycfx/index");
                }
                else
                {
                    return Redirect("/zuiMeiJiaoShi/login/index?type=" + type);
                }
                
            }
            else
            {
                return Redirect("/zuiMeiJiaoShi/login/index?msg=生日错误，请输入6位生日！如：930405&type=" + type);
            }
            
        }

        public ActionResult Logout()
        {
            Session["LoginUser"] = null;
            return Redirect("http://duyuwei.net");
        }

        public ActionResult Aboutme(string type)
        {
            ViewBag.type = type;
            return View();
        }

    }
}
