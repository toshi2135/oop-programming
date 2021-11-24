using System;
using System.Collections.Generic;
using System.Linq;
using HDT.DataAccess;
using HDT.Entities;

namespace HDT.Services
{
    public class XuLySanPham
    {
        // Properties
        private LuuTruSanPham LuuTruSanPham { get; set; }

        // Constructor
        public XuLySanPham()
        {
            LuuTruSanPham = new LuuTruSanPham();
        }

        // Methods
        public List<Product> TimKiemSanPham(string Keyword = "")
        {
            var dsSanPham = LuuTruSanPham.DocDanhSachSanPham();
            if (string.IsNullOrEmpty(Keyword) == false)
            {
                dsSanPham = dsSanPham.Where(p => p.Name.Contains(Keyword)).ToList();
            }
            return dsSanPham;
        }

        public void ThemSanPham(Product p)
        {
            LuuTruSanPham.ThemSanPham(p);
        }

        public Product DocSanPham(int id)
        {
            return LuuTruSanPham.DocSanPham(id);
        }

        public void SuaSanPham(Product p)
        {
            LuuTruSanPham.SuaSanPham(p);
        }

        public void XoaSanPham(Product p)
        {
            LuuTruSanPham.XoaSanPham(p);
        }
    }
}
