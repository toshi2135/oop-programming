using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDT.Entities;
using HDT.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class MH_DangNhapModel : PageModel
    {
        // Properties
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Chuoi { get; set; }
        public List<User> DsNguoiDung { get; set; }
        private XuLyNguoiDung XuLyNguoiDung { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            var xuLyNguoiDung = new XuLyNguoiDung();
            User u = xuLyNguoiDung.DangNhap(Username, Password);

            if (u != null)
            {
                HttpContext.Session.SetString("user", u.Username);
                Response.Redirect("MH_DS_SanPham");
            }
            else
            {
                Chuoi = "Đăng nhập không thành công!";
            }
        }
    }
}
