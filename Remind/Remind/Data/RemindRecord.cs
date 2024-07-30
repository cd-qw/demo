using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Remind.Data
{
    /// <summary>
    /// 记录
    /// </summary>
    [SugarTable("remind_record")]
    public class RemindRecord
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { set; get; }

        [DisplayName("类型")]
        public string Name { set; get; }

        [DisplayName("时间")]
        public DateTime Time { set; get; }
    }
}
