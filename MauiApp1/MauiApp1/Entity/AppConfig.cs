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
        public string Url { set; get; }
    }
}
