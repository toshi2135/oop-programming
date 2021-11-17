using System;
using HDT.DataAccess;
using HDT.Entities;

namespace HDT.Services
{
    public class XuLyNguoiDung
    {
        private LuuTruNguoiDung LuuTruNguoiDung { get; set; }
        public XuLyNguoiDung()
        {
            LuuTruNguoiDung = new LuuTruNguoiDung();
        }

        public void ThemNguoiDung(User u)
        {
            u.NgayTao = DateTime.UtcNow;
            LuuTruNguoiDung.ThemNguoiDung(u);
        }
    }
}
