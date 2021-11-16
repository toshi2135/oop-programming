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
    public class MH_LuuTru_PhanSoModel : PageModel
    {
        // Se duoc hien thi voi GET method
        public void OnGet()
        {
        }

        // Se duoc hien thi voi POST method
        public void OnPost()
        {
            int x = int.Parse(Request.Form["x"]);
            int y = int.Parse(Request.Form["y"]);

            PhanSo p = new PhanSo(x, y);

            var xuLyPhanSo = new XuLyPhanSo();
            xuLyPhanSo.LuuPhanSo(p);
        }
    }
}
