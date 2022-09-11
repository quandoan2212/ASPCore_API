using BLL;
using Common.Req;
using Common.Resp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyLichPhongMay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongMayController : ControllerBase
    {
        private PhongMaySrv phongMaySrv;
        public PhongMayController()
        {
            this.phongMaySrv = new PhongMaySrv();
        }

        [HttpPost("get-by-id")]
        public IActionResult GetPhongMayById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = phongMaySrv.Read(req.Keyword);
            return Ok(res);
        }
    }
}
