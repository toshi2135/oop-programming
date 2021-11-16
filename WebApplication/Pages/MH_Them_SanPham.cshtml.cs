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
    public class MH_Them_SanPhamModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Price { get; set; }

        public string Chuoi { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            Product p = new Product();
            p.Name = Name;
            p.Price = Price;

            var xuLySanPham = new XuLySanPham();
            xuLySanPham.ThemSanPham(p);

            Chuoi = "Da luu thanh cong";
            Response.Redirect("MH_DS_SanPham");
        }
    }
}
