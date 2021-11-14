using System;
namespace oop_programming
{
    public class MATPHANG
    {
        // Thanh phan du lieu
        private HINHTRON[] dsHINHTRON;
        private HINHCHUNHAT[] dsHINHCHUNHAT;

        // Thanh phan xu li
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);

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
        }

        public double TinhTongChuVi()
        {
            double S = 0;
            for (int i = 0; i < this.dsHINHTRON.Length; i++)
            {
                S += this.dsHINHTRON[i].TinhChuVi();
            }
            for (int i = 0; i < this.dsHINHCHUNHAT.Length; i++)
            {
                S += this.dsHINHCHUNHAT[i].TinhChuVi();
            }
            return S;
        }

    }
}
