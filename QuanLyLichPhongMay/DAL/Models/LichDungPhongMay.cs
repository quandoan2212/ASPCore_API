using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LichDungPhongMay
    {
        public string MaMon { get; set; }
        public string MaGv { get; set; }
        public string MaPhong { get; set; }
        public short CaHoc { get; set; }
        public DateTime NgayHoc { get; set; }
        public string MaLich { get; set; }

        public virtual GiangVien MaGvNavigation { get; set; }
        public virtual MonHoc MaMonNavigation { get; set; }
        public virtual PhongMay MaPhongNavigation { get; set; }
    }
}
