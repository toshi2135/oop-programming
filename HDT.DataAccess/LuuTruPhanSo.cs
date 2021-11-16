using System;
using System.IO;
using HDT.Entities;
using Newtonsoft.Json;

namespace HDT.DataAccess
{
    public class LuuTruPhanSo
    {
        public void LuuPhanSo(PhanSo p)
        {
            string jsonString = JsonConvert.SerializeObject(p);
            FileStream file = new FileStream("/Users/tuan.nguyen/phanso.json");
            file.Write(jsonString);
            file.Close();
        }
    }
}