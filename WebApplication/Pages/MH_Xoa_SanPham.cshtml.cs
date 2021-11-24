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
    public class MH_Xoa_SanPhamModel : PageModel
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

        [BindProperty(SupportsGet = true)]
        public int PId { get; set; }

        public string Chuoi { get; set; }

        public void OnGet()
        {
            var xuLySanPham = new XuLySanPham();
            Product p = xuLySanPham.DocSanPham(PId);
            if (p != null)
            {
                Name = p.Name;
                Price = p.Price;
                Duration = p.Duration;
                Company = p.Company;
                Year = p.Year;
                TypeName = p.TypeName;
            }
            else
            {
                Chuoi = "Sản phẩm không tồn tại";

            }
        }

        public void OnPost()
        {
            Product p = new Product();
            p.Id = PId;
            p.Name = Name;
            p.Price = Price;
            p.Duration = Duration;
            p.Company = Company;
            p.Year = Year;
            p.TypeName = TypeName;

            var xuLySanPham = new XuLySanPham();
            xuLySanPham.XoaSanPham(p);

            Chuoi = "Đã xóa thành công";
            Response.Redirect("MH_DS_SanPham");
        }
    }
}
