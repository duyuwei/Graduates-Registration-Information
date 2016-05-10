using FluentData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duyuwei.Areas.biyesheng
{
    class DBhelper
    {
        public static IDbContext QueryDB()
        {
            string path = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            IDbContext db = new DbContext().ConnectionString(path, new SqlServerProvider());
            return db;
        }
       
    }
}
