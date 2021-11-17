using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HDT.Entities;
using Newtonsoft.Json;

namespace HDT.DataAccess
{
    public class LuuTruSanPham
    {
        public List<Product> DocDanhSachSanPham()
        {
            StreamReader file = new StreamReader("./data/products.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var kq = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            return kq;
        }

        public void LuuDanhSachSanPham(List<Product> dsSanPham)
        {
            StreamWriter file = new StreamWriter("./data/products.json");
            string jsonString = JsonConvert.SerializeObject(dsSanPham);
            file.Write(jsonString);

            file.Close();
        }

        public void ThemSanPham(Product p)
        {
            var dsSanPham = DocDanhSachSanPham();

            int maxId = dsSanPham.Max(p => p.Id);
            p.Id = maxId + 1;
            dsSanPham.Add(p);

            LuuDanhSachSanPham(dsSanPham);
        }



        public Product DocSanPham(int id)
        {
            var dsSanPham = DocDanhSachSanPham();
            return dsSanPham.FirstOrDefault(p => p.Id == id);
        }

        public void SuaSanPham(Product p0)
        {
            var dsSanPham = DocDanhSachSanPham();
            var product = dsSanPham.FirstOrDefault(p => p.Id == p0.Id);
            if (product != null)
            {
                product.Name = p0.Name;
                product.Price = p0.Price;
            }
            LuuDanhSachSanPham(dsSanPham);
        }
    }
}
