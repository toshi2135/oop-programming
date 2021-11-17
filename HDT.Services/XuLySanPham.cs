using System;
using System.Collections.Generic;
using System.Linq;
using HDT.DataAccess;
using HDT.Entities;

namespace HDT.Services
{
    public class XuLySanPham
    {
        private LuuTruSanPham LuuTruSanPham { get; set; }
        public XuLySanPham()
        {
            LuuTruSanPham = new LuuTruSanPham();
        }

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
    }
}
