using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            LichDungPhongMays = new HashSet<LichDungPhongMay>();
        }

        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public short SoTietTh { get; set; }

        public virtual ICollection<LichDungPhongMay> LichDungPhongMays { get; set; }
    }
}
