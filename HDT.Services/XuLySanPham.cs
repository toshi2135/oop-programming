using System;
using System.Collections.Generic;
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

        public List<Product> TimKiemSanPham()
        {
            var dsSanPham = LuuTruSanPham.DocDanhSachSanPham();
            return dsSanPham;
        }
    }
}
