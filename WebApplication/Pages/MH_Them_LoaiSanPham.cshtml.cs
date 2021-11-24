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
    public class MH_Them_LoaiSanPhamModel : PageModel
    {
        // Properties
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
            ProductType pt = new ProductType();
            pt.TypeName = TypeName;

            var xuLyLoaiSanPham = new XuLyLoaiSanPham();
            xuLyLoaiSanPham.ThemLoaiSanPham(pt);

            Chuoi = "Đã lưu thành công";
            Response.Redirect("MH_DS_LoaiSanPham");
        }
    }
}
