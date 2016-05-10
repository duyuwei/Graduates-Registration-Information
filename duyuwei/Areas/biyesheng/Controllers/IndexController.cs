using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentData;
using duyuwei.Areas.biyesheng.Models;

namespace duyuwei.Areas.biyesheng.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /biyesheng/Index/
        

        [HttpGet]
        public ActionResult Index()
        {
            if ( Session["LoginUser"]==null)
            {
                return Redirect("/biyesheng/login/Index");
            }
            string xh = Session["LoginUser"].ToString();
            IDbContext db = DBhelper.QueryDB();
            string sqlStr = "SELECT * FROM ziyuan where xh=" + xh;
            ziyuan StudentInfo = db.Sql(sqlStr).QuerySingle<ziyuan>();
            List<dm> zzmm = db.Sql("select * from dm where type='政治面貌'").QueryMany<dm>();
            List<dm> xjbd = db.Sql("select * from dm where type='学籍变动' order by code").QueryMany<dm>();
            List<dm> pyfs = db.Sql("select * from dm where type='培养方式' order by code").QueryMany<dm>();
            List<dm> knslbdm = db.Sql("select * from dm where type='困难生类别'").QueryMany<dm>();
            ViewData.Model = StudentInfo;
            ViewBag.zzmm = zzmm;
            ViewBag.xjbd = xjbd;
            ViewBag.pyfs = pyfs;
            ViewBag.knslbdm = knslbdm;
            return View();
        }

        [HttpPost]
        public ActionResult Index(ziyuan Info) 
        {

            IDbContext db = DBhelper.QueryDB();
           
            Info.zzmm = db.Sql("SELECT value FROM dbo.dm where type='政治面貌' and code='" + Info.zzmmdm + "'").QuerySingle<string>();//政治面貌
            Info.pyfs = db.Sql("SELECT value FROM dbo.dm where type='培养方式' and code='" + Info.pyfsdm + "'").QuerySingle<string>();//培养方式
            Info.xjbd = db.Sql("SELECT value FROM dbo.dm where type='学籍变动' and code='" + Info.xjbddm + "'").QuerySingle<string>();//学籍变动
            Info.syszd = db.Sql("select xzqhmc from dbo.xz where xzqhdm='" + Info.syszddm + "'").QuerySingle<string>();//行政区代码
            
            db.Update<ziyuan>("ziyuan", Info)
                .AutoMap(x => x.xh)
                .Where(x => x.xh).Execute();
            return View("success");
       
        }

        public JsonResult Search(string syszdSearch)
        {
            JsonResult json=new JsonResult();
            IDbContext db=DBhelper.QueryDB();
            string sqlStr = "select * from dbo.xz where xzqhmc like '%" + syszdSearch + "%'";
            List<xz> xz = db.Sql(sqlStr).QueryMany<xz>();
            json.Data=xz;
            return json;
        }

    }
}
