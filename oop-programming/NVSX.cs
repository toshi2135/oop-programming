using System;
namespace oop_programming
{
    public class NVSX
    {
        // Thanh phan du lieu
        private string maNV;
        private string ten;
        private string diaChi;
        private int soLuongSP;

        // Constructor
        public NVSX(string maNV, string ten, string diaChi, int soLuongSP)
        {
            this.maNV = maNV;
            this.ten = ten;
            this.diaChi = diaChi;
            this.soLuongSP = soLuongSP;
        }

        // Properties
        public string MaNV
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
        
        // Thanh phan xu li
        public void NhapNhanVien (string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien: ");
            this.maNV = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.soLuongSP = int.Parse(Console.ReadLine());
        }
    }
}
