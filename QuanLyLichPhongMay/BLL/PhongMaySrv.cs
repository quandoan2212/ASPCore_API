using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using Common.BLL;
using DAL.Models;
using Common.Resp;

namespace BLL
{
    public class PhongMaySrv:GenericSrv<PhongMayResp, PhongMay>
    {
        private PhongMayResp phongMayResp;
        public PhongMaySrv()
        {
            phongMayResp = new PhongMayResp();
        }

        public override SingleRsp Read(string id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
    }
}
