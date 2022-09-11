using Common.DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class PhongMayResp:GenericRep<QuanLyHeThongPhongMayContext, PhongMay>
    {
        public PhongMayResp()
        {

        }

        public override PhongMay Read(string id)
        {
            var res = All.FirstOrDefault(p => p.MaPhong.Equals(id));
            return res;
        }
    }
}
