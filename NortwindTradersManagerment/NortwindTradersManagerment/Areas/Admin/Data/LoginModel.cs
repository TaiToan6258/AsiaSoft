using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NortwindTradersManagerment.Areas.Admin.Data
{
    namespace QuanLyBanHang.Areas.Admin.Data
    {
        public class LoginModel
        {
            [Required(ErrorMessage = "Nhap Lai UserName")]
            public string username { set; get; }

            [Required(ErrorMessage = "Nhap Lai Password")]
            public string password { set; get; }
            public bool RememberMe { set; get; }
        }
    }
}