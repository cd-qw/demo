using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbclMes.Entity
{
    /// <summary>
    /// 程序配置
    /// </summary>
    [SugarTable("config")]
    public class AppConfig
    {
        [SugarColumn(IsPrimaryKey = true)]
        public int Id { set; get; }
        /// <summary>
        /// 默认地址
        /// </summary>
        public string Url { set; get; }

        /// <summary>
        /// 临时地址
        /// </summary>
        public string TempUrl { set; get; }

        /// <summary>
        /// 缓存
        /// </summary>
        public string LocalStorage { set; get; }
    }
}
