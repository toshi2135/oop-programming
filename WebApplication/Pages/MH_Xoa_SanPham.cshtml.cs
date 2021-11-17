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
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Price { get; set; }
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
            }
            else
            {
                Chuoi = "San pham khong ton tai";

            }
        }

        public void OnPost()
        {
            Product p = new Product();
            p.Id = PId;
            p.Name = Name;
            p.Price = Price;

            var xuLySanPham = new XuLySanPham();
            xuLySanPham.XoaSanPham(p);

            Chuoi = "Đã xóa thành công";
            Response.Redirect("MH_DS_SanPham");
        }
    }
}
