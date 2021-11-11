using System;
namespace oop_programming
{
    public class PHAN_SO
    {
        // Thanh phan du lieu
        public int TuSo;
        public int MauSo;

        // Thanh phan xu li
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            // this = Doi tuong de goi ham/thuc hien hanh dong
            this.TuSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau so: ");
            this.TuSo = int.Parse(Console.ReadLine());
        }
    }
}
