using System;
namespace oop_programming
{
    public abstract class HINH
    {
        // Thanh phan du lieu
        // Properties
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string MauSac { get; set; }

        // Thanh phan xu li
        // Constructor
        public HINH()
        {
        }

        public virtual void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma: ");
            this.Ma = Console.ReadLine();
            Console.WriteLine("Nhap ten: ");
            this.Ten = Console.ReadLine();
            Console.WriteLine("Nhap ma: ");
            this.MauSac = Console.ReadLine();
        }

        public abstract double TinhChuVi();
    }
    interface IFly
    {
        void Fly();
        void Fly1();
    }
}
