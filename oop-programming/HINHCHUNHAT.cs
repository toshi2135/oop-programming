﻿using System;
namespace oop_programming
{
    public class HINHCHUNHAT : HINH, IFly
    {
        // Thanh phan du lieu
        // Properties
        public TOA_DO A { get; set; }
        public int Dai { get; set; }
        public int Rong { get; set; }

        public HINHCHUNHAT()
        {
        }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            this.A = new TOA_DO();
            this.A.Nhap("Nhap dinh A");
            Console.WriteLine("Nhap chieu dai: ");
            this.Dai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            this.Rong = int.Parse(Console.ReadLine());
        }

        public override double TinhChuVi()
        {
            return (this.Dai + this.Rong) * 2;
        }

        public void Fly()
        {
            Console.WriteLine("I Can Fly");
        }
        public void Fly1()
        {
            Console.WriteLine("I Can Fly 1");
        }
    }
}
