using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace duyuwei.Areas.zuiMeiJiaoShi.Models
{
    public class zmjs_studentsInfo
    {
        /// <summary>
        /// sfzh
        /// </summary>
        public string sfzh { get; set; }
        /// <summary>
        /// xm
        /// </summary>
        public string xm { get; set; }
        /// <summary>
        /// zyfx
        /// </summary>
        public string zyfx { get; set; }
        /// <summary>
        /// xh
        /// </summary>
        public string xh { get; set; }
        /// <summary>
        /// teacher
        /// </summary>
        public string teacher { get; set; }
        /// <summary>
        /// reason
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// 是否已经提过建议
        /// </summary>
        public string isSuggested { get; set; }
        /// <summary>
        /// 分享的话
        /// </summary>
        public string share { get; set; }
    }
}