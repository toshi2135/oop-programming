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
            StreamWriter file = new StreamWriter("/Users/tuan.nguyen/Documents/GitHub/oop-programming/phanso.json");
            file.Write(jsonString);
            file.Close();
        }
    }
}