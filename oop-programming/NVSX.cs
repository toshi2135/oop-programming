using System;
namespace oop_programming
{
    public class NVSX
    {
        // Thanh phan du lieu
        private string ma;
        private string ten;
        private string diaChi;
        private int soLuongSP;

        // Constructor
        public NVSX(string maNV, string tenNV, string diaChiNV, int soLuongSPNV)
        {
            this.ma = maNV;
            this.ten = tenNV;
            this.diaChi = diaChiNV;
            this.soLuongSP = soLuongSPNV;
        }

        // Properties
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
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
        
        // Thanh phan xu li
        public void NhapNhanVien (string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.soLuongSP = int.Parse(Console.ReadLine());
        }
    }
}
