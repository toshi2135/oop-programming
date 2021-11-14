using System;
using System.Collections.Generic;

namespace oop_programming
{
    public class MATPHANG
    {
        // Thanh phan du lieu
        // private HINHTRON[] dsHINHTRON;
        // private HINHCHUNHAT[] dsHINHCHUNHAT;
        private List<HINH> dsHinh;

        public MATPHANG()
        {
            this.dsHinh = new List<HINH>();
        }

        // Thanh phan xu li
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);

            /*
            int N;
            Console.WriteLine("Nhap so luong hinh tron: ");
            N = int.Parse(Console.ReadLine());
            this.dsHINHTRON = new HINHTRON[N];
            for (int i=0; i<this.dsHINHTRON.Length; i++)
            {
                this.dsHINHTRON[i] = new HINHTRON();
                this.dsHINHTRON[i].NhapHinhTron($"Nhap hinh tron thu {i + 1}: ");
            }

            Console.WriteLine("Nhap so luong hinh chu nhat: ");
            N = int.Parse(Console.ReadLine());
            this.dsHINHCHUNHAT = new HINHCHUNHAT[N];
            for (int i = 0; i < this.dsHINHCHUNHAT.Length; i++)
            {
                this.dsHINHCHUNHAT[i] = new HINHCHUNHAT();
                this.dsHINHCHUNHAT[i].NhapHinhChuNhat($"Nhap hinh chu nhat thu {i + 1}: ");
            }
            */

            int N;
            Console.WriteLine("Nhap so luong hinh");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap loai hinh (1. Hinh tron; 2. Hinh chu nhat");
                int loai = int.Parse(Console.ReadLine());
                HINH hinh;
                if (loai == 1)
                {
                    hinh = new HINHTRON();
                }
                else
                {
                    hinh = new HINHCHUNHAT();
                }

                hinh.Nhap($"Nhap hinh thu {i + 1}");
                this.dsHinh.Add(hinh);
            }

        }

        public double TinhTongChuVi()
        {
            double S = 0;
            /*
            for (int i = 0; i < this.dsHINHTRON.Length; i++)
            {
                S += this.dsHINHTRON[i].TinhChuVi();
            }
            for (int i = 0; i < this.dsHINHCHUNHAT.Length; i++)
            {
                S += this.dsHINHCHUNHAT[i].TinhChuVi();
            }
            */

            for (int i = 0; i < this.dsHinh.Count; i++)
            {
                S += this.dsHinh[i].TinhChuVi();
            }
            return S;
        }

    }
}
