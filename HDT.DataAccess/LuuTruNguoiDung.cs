using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HDT.Entities;
using Newtonsoft.Json;

namespace HDT.DataAccess
{
    public class LuuTruNguoiDung
    {
        public List<User> DocDanhSachNguoiDung()
        {
            StreamReader file = new StreamReader("./data/users.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var kq = JsonConvert.DeserializeObject<List<User>>(jsonString);

            return kq;
        }

        public void LuuDanhSachNguoiDung(List<User> dsNguoiDung)
        {
            StreamWriter file = new StreamWriter("./data/users.json");
            string jsonString = JsonConvert.SerializeObject(dsNguoiDung);
            file.Write(jsonString);

            file.Close();
        }

        public void ThemNguoiDung(User u)
        {
            var dsNguoiDung = DocDanhSachNguoiDung();

            int maxId = 0;
            if (dsNguoiDung.Count > 0)
            {
                dsNguoiDung.Max(u => u.Id);

            }
            u.Id = maxId + 1;
            dsNguoiDung.Add(u);

            LuuDanhSachNguoiDung(dsNguoiDung);
        }
    }
}
