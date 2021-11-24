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
        // Properties
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Price { get; set; }
        [BindProperty]
        public int Duration { get; set; }
        [BindProperty]
        public string Company { get; set; }
        [BindProperty]
        public int Year { get; set; }
        [BindProperty]
        public string TypeName { get; set; }

        public string Chuoi { get; set; }

        // Methods
        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            Product p = new Product();
            p.Name = Name;
            p.Price = Price;
            p.Duration = Duration;
            p.Company = Company;
            p.Year = Year;
            p.TypeName = TypeName;

            ProductType pt = new ProductType();
            pt.TypeName = p.TypeName;

            var xuLySanPham = new XuLySanPham();
            xuLySanPham.ThemSanPham(p);

            var xuLyLoaiSanPham = new XuLyLoaiSanPham();
            xuLyLoaiSanPham.ThemLoaiSanPham(pt);

            Chuoi = "Đã lưu thành công";
            Response.Redirect("MH_DS_SanPham");
        }
    }
}
