using System;
namespace oop_programming
{
    public class NVVP : NHANVIEN
    {
        // Thanh phan du lieu
        private int phuCap;
        private double heSo;

        // Constructor
        /*
        public NVVP(string maNV, string tenNV, string diaChiNV, int phuCapNV, double heSoNV)
        {
            this.ma = maNV;
            this.ten = tenNV;
            this.diaChi = diaChiNV;
            this.phuCap = phuCapNV;
            this.heSo = heSoNV;
        }
        */

        // Properties
        public int PhuCap { get; set; }
        public double HeSo { get; set; }

        // Thanh phan xu li
        public void NhapNhanVien(string ghiChu)
        {
            this.Nhap(ghiChu);
            Console.WriteLine("Nhap phu cap: ");
            this.phuCap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            this.heSo = double.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return this.heSo * 10 + this.phuCap;
        }
    }
}
