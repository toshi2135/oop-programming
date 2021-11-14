using System;
namespace oop_programming
{
    public class NVSX
    {
        // Thanh phan du lieu
        private int maNV;
        private string ten;
        private string diaChi;
        private int soLuongSP;

        // Constructor
        public NVSX(int maNV, string ten, string diaChi, int soLuongSP)
        {
            this.maNV = maNV;
            this.ten = ten;
            this.diaChi = diaChi;
            this.soLuongSP = soLuongSP;
        }

        // Properties
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public int SoLuongSP
        {
            get { return soLuongSP; }
            set { soLuongSP = value; }
        }

    }
}
