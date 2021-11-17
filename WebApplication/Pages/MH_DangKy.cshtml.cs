using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDT.Entities;
using HDT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class MH_DangKyModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public string Chuoi { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            User u = new User();
            u.Username = Username;
            u.Password = Password;

            var xuLyNguoiDung = new XuLyNguoiDung();
            xuLyNguoiDung.ThemNguoiDung(u);
        }
    }
}
