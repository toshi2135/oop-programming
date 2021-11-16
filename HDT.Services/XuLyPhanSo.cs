using System;
using HDT.Entities;
using HDT.DataAccess;

namespace HDT.Services
{
    public class XuLyPhanSo
    {
        private LuuTruPhanSo LuuTruPhanSo { get; set; }

        public XuLyPhanSo()
        {
            this.LuuTruPhanSo = new LuuTruPhanSo();
        }

        public void LuuPhanSo(XuLyPhanSo p)
        {
            LuuTruPhanSo.LuuPhanSo(p);
        }
    }
}
