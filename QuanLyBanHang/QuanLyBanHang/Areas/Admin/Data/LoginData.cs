using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Areas.Admin.Data
{
    public class LoginData
    {
        [Required(ErrorMessage = "Nhap Lai UserName")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Nhap Lai Password")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}