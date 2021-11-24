using System;
using System.Collections.Generic;
using System.Linq;
using HDT.DataAccess;
using HDT.Entities;

namespace HDT.Services
{
    public class XuLyLoaiSanPham
    {
        // Properties
        private LuuTruLoaiSanPham LuuTruLoaiSanPham { get; set; }

        // Constructor
        public XuLyLoaiSanPham()
        {
            LuuTruLoaiSanPham = new LuuTruLoaiSanPham();
        }

        // Methods
        public List<ProductType> TimKiemLoaiSanPham(string Keyword = "")
        {
            var dsLoaiSanPham = LuuTruLoaiSanPham.DocDanhSachLoaiSanPham();
            if (string.IsNullOrEmpty(Keyword) == false)
            {
                dsLoaiSanPham = dsLoaiSanPham.Where(p => p.TypeName.Contains(Keyword)).ToList();
            }
            return dsLoaiSanPham;
        }

        public void ThemLoaiSanPham(ProductType p)
        {
            LuuTruLoaiSanPham.ThemLoaiSanPham(p);
        }

        public ProductType DocLoaiSanPham(int id)
        {
            return LuuTruLoaiSanPham.DocLoaiSanPham(id);
        }

        public void SuaLoaiSanPham(ProductType p)
        {
            LuuTruLoaiSanPham.SuaLoaiSanPham(p);
        }

        public void XoaLoaiSanPham(ProductType p)
        {
            LuuTruLoaiSanPham.XoaLoaiSanPham(p);
        }
    }
}
