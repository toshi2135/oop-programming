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
    public class MH_DS_SanPhamModel : PageModel
    {
        // Properties
        public List<Product> DsSanPham { get; set; }
        private XuLySanPham XuLySanPham { get; set; }
        // Constructor
        public MH_DS_SanPhamModel():base()
        {
            XuLySanPham = new XuLySanPham();
        }

        public void OnGet()
        {
            DsSanPham = XuLySanPham.TimKiemSanPham();
        }
    }
}
