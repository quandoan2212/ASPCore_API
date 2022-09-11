using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PhongMay
    {
        public PhongMay()
        {
            LichDungPhongMays = new HashSet<LichDungPhongMay>();
        }

        public string MaPhong { get; set; }
        public short SoMay { get; set; }

        public virtual ICollection<LichDungPhongMay> LichDungPhongMays { get; set; }
    }
}
