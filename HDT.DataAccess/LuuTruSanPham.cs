using System;
using System.Collections.Generic;
using System.IO;
using HDT.Entities;
using Newtonsoft.Json;

namespace HDT.DataAccess
{
    public class LuuTruSanPham
    {
        public List<Product> DocDanhSachSanPham()
        {
            StreamReader file = new StreamReader("/Users/tuan.nguyen/Documents/GitHub/oop-programming/data/products.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var kq = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            return kq;
        }
    }
}
