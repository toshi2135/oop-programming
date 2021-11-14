using System;
namespace oop_programming
{
    public class HINHTRON : HINH
    {
        // Thanh phan du lieu
        // Properties
        public TOA_DO I { get; set; }
        public double R { get; set; }

        // Thanh phan xu li
        public HINHTRON()
        {
        }

        public void NhapHinhTron(string ghiChu)
        {
            base.Nhap(ghiChu);
            this.I = new TOA_DO();
            this.I.Nhap("Nhap tam I");
            Console.WriteLine("Nhap ban kinh: ");
            this.R = double.Parse(Console.ReadLine());
        }

        public double TinhChuVi()
        {
            return Math.PI * Math.Pow(this.R, 2);
        }
    }
}
