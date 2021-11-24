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
    public class MH_DS_LoaiSanPhamModel : PageModel
    {
        // Properties
        public List<ProductType> DsLoaiSanPham { get; set; }
        private XuLyLoaiSanPham XuLyLoaiSanPham { get; set; }

        [BindProperty]
        public string Keyword { get; set; }

        // Constructor
        public MH_DS_LoaiSanPhamModel() : base()
        {
            XuLyLoaiSanPham = new XuLyLoaiSanPham();
        }

        public void OnGet()
        {
            DsLoaiSanPham = XuLyLoaiSanPham.TimKiemLoaiSanPham();
        }

        public void OnPost()
        {
            DsLoaiSanPham = XuLyLoaiSanPham.TimKiemLoaiSanPham(Keyword);
        }
    }
}
