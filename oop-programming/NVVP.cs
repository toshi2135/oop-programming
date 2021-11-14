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
        // Vi du ve hanm ao
        public override void F_AO()
        {
            Console.WriteLine("Ham F_AO cua lop NVVP");
        }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Console.WriteLine("Nhap phu cap: ");
            this.phuCap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            this.heSo = double.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return this.heSo * 10 + this.phuCap;
        }
    }
}
