using System;
namespace oop_programming
{
    public class TOA_DO
    {
        // Thanh phan du lieu
        public int x;
        public int y;

        // Thanh phan xu li
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap x: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            this.y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(TOA_DO b)
        {
            double kq;
            kq = Math.Sqrt(Math.Pow(this.x - b.x, 2) + Math.Pow(this.y - b.y, 2));
            return kq;
        }

        
    }
}
