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

        public User DangNhap(string Username, string Password)
        {
            var dsNguoiDung = LuuTruNguoiDung.DocDanhSachNguoiDung();
            foreach (var user in dsNguoiDung)
            {
                if (user.Username == Username && user.Password == Password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
