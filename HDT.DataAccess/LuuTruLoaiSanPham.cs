using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HDT.Entities;
using Newtonsoft.Json;

namespace HDT.DataAccess
{
    public class LuuTruLoaiSanPham
    {
        public List<ProductType> DocDanhSachLoaiSanPham()
        {
            StreamReader file = new StreamReader("./data/product_types.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var kq = JsonConvert.DeserializeObject<List<ProductType>>(jsonString);

            return kq;
        }

        public void LuuDanhSachLoaiSanPham(List<ProductType> dsLoaiSanPham)
        {
            StreamWriter file = new StreamWriter("./data/product_types.json");
            string jsonString = JsonConvert.SerializeObject(dsLoaiSanPham);
            file.Write(jsonString);

            file.Close();
        }
        
        public void ThemLoaiSanPham(ProductType p)
        {
            var dsLoaiSanPham = DocDanhSachLoaiSanPham();

            int maxId = dsLoaiSanPham.Max(p => p.Id);
            // p.Id = maxId + 1;
            dsLoaiSanPham.Add(p);

            LuuDanhSachLoaiSanPham(dsLoaiSanPham);
        }

        public ProductType DocLoaiSanPham(int Id)
        {
            var dsLoaiSanPham = DocDanhSachLoaiSanPham();
            return dsLoaiSanPham.FirstOrDefault(p => p.Id == Id);
        }

        public void SuaLoaiSanPham(ProductType p0)
        {
            var dsLoaiSanPham = DocDanhSachLoaiSanPham();

            var ProductType = dsLoaiSanPham.FirstOrDefault(p => p.Id == p0.Id);
            if (ProductType != null)
            {
                ProductType.TypeName = p0.TypeName;
            }

            LuuDanhSachLoaiSanPham(dsLoaiSanPham);
        }

        public void XoaLoaiSanPham(ProductType p0)
        {
            var dsLoaiSanPham = DocDanhSachLoaiSanPham();

            var ProductType = dsLoaiSanPham.FirstOrDefault(p => p.Id == p0.Id);
            if (ProductType != null)
            {
                dsLoaiSanPham.Remove(ProductType);
                LuuDanhSachLoaiSanPham(dsLoaiSanPham);
            }
        }
    }
}
