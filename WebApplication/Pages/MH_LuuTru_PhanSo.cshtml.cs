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
    // Xu ly du lieu dau vao, xac dinh du lieu cho Razor Views
    public class MH_LuuTru_PhanSoModel : PageModel
    {
        [BindProperty]
        public int X { get; set; }
        [BindProperty]
        public int Y { get; set; }
        public string Chuoi { get; set; }

        // Se duoc hien thi voi GET method
        public void OnGet()
        {
            X = 10;
            Y = 20;
            Chuoi = string.Empty;
        }

        // Se duoc hien thi voi POST method
        public void OnPost()
        {
            // int x = int.Parse(Request.Form["x"]);
            // int y = int.Parse(Request.Form["y"]);

            PhanSo p = new PhanSo(X, Y);

            var xuLyPhanSo = new XuLyPhanSo();
            xuLyPhanSo.LuuPhanSo(p);

            Chuoi = "Da luu thanh cong";
        }
    }
}
