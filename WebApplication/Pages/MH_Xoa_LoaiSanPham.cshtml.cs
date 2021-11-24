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
    public class MH_Xoa_LoaiSanPhamModel : PageModel
    {
        // Properties
        [BindProperty]
        public string TypeName { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PId { get; set; }

        public string Chuoi { get; set; }

        public void OnGet()
        {
            var xuLyLoaiSanPham = new XuLyLoaiSanPham();
            ProductType p = xuLyLoaiSanPham.DocLoaiSanPham(PId);
            if (p != null)
            {
                TypeName = p.TypeName;
            }
            else
            {
                Chuoi = "Loại sản phẩm không tồn tại";

            }
        }

        public void OnPost()
        {
            ProductType p = new ProductType();

            p.TypeName = TypeName;

            var xuLyLoaiSanPham = new XuLyLoaiSanPham();
            xuLyLoaiSanPham.XoaLoaiSanPham(p);

            Chuoi = "Đã xóa thành công";
            Response.Redirect("MH_DS_SanPham");
        }
    }
}
