﻿using System;
namespace oop_programming
{
    public class PHAN_SO
    {
        // Thanh phan du lieu
        private int TuSo;
        private int MauSo;

        // Thanh phan xu li

        // Ham tao (constructor)
        public PHAN_SO()
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }

        public PHAN_SO(int t)
        {
            this.TuSo = t;
            this.MauSo = 1;
        }

        public PHAN_SO(int t, int m)
        {
            this.TuSo = t;
            if (m!=0)
            {
                this.MauSo = m;
            }
            else
            {
                this.MauSo = 1;
            }
        }

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            // this = Doi tuong de goi ham/thuc hien hanh dong
            this.TuSo = int.Parse(Console.ReadLine());

            int m = 0;
            do
            {
                Console.WriteLine("Nhap mau so: ");
                m = int.Parse(Console.ReadLine());
            } while (m == 0);
            this.MauSo = m;
        }

        public int LayTuSo()
        {
            return this.TuSo;
        }

        public int LayMauSo()
        {
            return this.MauSo;
        }

        public void GanMauSo(int m)
        {
            if (m!=0)
            {
                this.MauSo = m;
            }
        }

        public int TU_SO_GON { get; set; }

        public int MAU_SO
        {
            get
            {
                return this.MauSo;
            }
            set
            {
                if (value != 0)
                {
                    this.MauSo = value;
                }
                else
                {
                    throw new MyException("Mau so khong duoc = 0");
                }
            }
        }

        public PHAN_SO CongPhanSo(PHAN_SO b)
        {
            PHAN_SO kq;
            kq = new PHAN_SO();
            kq.TuSo = this.TuSo * b.MauSo + this.MauSo * b.TuSo;
            kq.MauSo = this.MauSo * b.MauSo;

            return kq;
        }
        public string Xuat()
        {
            return $"{this.TuSo}/{this.MauSo}";
        }
    }
}
