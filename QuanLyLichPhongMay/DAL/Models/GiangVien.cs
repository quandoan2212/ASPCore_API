using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            LichDungPhongMays = new HashSet<LichDungPhongMay>();
        }

        public string MaGv { get; set; }
        public string HoTen { get; set; }
        public string SoDt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<LichDungPhongMay> LichDungPhongMays { get; set; }
    }
}
