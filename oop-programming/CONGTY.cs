using System;
using System.Collections.Generic;

namespace oop_programming
{
    public class CONGTY
    {
        // Thanh phan du lieu
        private string ten;
        // private NVSX[] dsNVSX;
        // private NVVP[] dsNVVP;
        private List<NHANVIEN> dsNhanVien;

        // Constructor
        public CONGTY()
        {
            this.dsNhanVien = new List<NHANVIEN>();
        }

        // Thanh phan xu li
        public void NhapCty(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten cong ty: ");
            this.ten = Console.ReadLine();

            /*
            int N;
            Console.WriteLine("Nhap so luong NVVP: ");
            N = int.Parse(Console.ReadLine());
            this.dsNVVP = new NVVP[N];
            for (int i = 0; i < this.dsNVVP.Length; i++)
            {
                this.dsNVVP[i] = new NVVP();
                this.dsNVVP[i].NhapNhanVien($"Nhap NVVP thu {i + 1}: ");
            }

            Console.WriteLine("Nhap so luong NVSX: ");
            N = int.Parse(Console.ReadLine());
            this.dsNVSX = new NVSX[N];
            for (int i = 0; i < this.dsNVSX.Length; i++)
            {
                this.dsNVSX[i] = new NVSX();
                this.dsNVSX[i].NhapNhanVien($"Nhap NVSX thu {i + 1}: ");
            }
            */
            int N;
            Console.WriteLine("Nhap so luong nhan vien: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap loai nhan vien (1. NVSX; 2. NVVP");
                int loai = int.Parse(Console.ReadLine());
                NHANVIEN nv;
                if (loai == 1)
                {
                    nv = new NVSX();
                }
                else
                {
                    nv = new NVVP();
                }

                nv.Nhap("Nhap thong tin nhan vien: ");
                this.dsNhanVien.Add(nv);
            }
        }

        public double TinhTongLuong()
        {
            
            double S = 0;

            /*
            for (int i = 0; i < this.dsNVVP.Length; i++)
            {
                S += this.dsNVVP[i].TinhLuong();
            }
            for (int i = 0; i < this.dsNVSX.Length; i++)
            {
                S += this.dsNVSX[i].TinhLuong();
            }
            */

            // Dung Da hinh
            for (int i = 0; i < this.dsNhanVien.Count; i++)
            {
                S += this.dsNhanVien[i].TinhLuong();
            }
            return S;
        }

    }
}
