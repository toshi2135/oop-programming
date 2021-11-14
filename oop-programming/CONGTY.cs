using System;
namespace oop_programming
{
    public class CONGTY
    {
        // Thanh phan du lieu
        private string ten;
        private NVSX[] dsNVSX;
        private NVVP[] dsNVVP;

        // Constructor
        public CONGTY()
        {

        }
        public CONGTY(string tenCTY)
        {
            this.ten = tenCTY;
        }

        // Properties
        public string TenCTY { get; set; }

        // Thanh phan xu li
        public void NhapCty(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten cong ty: ");
            this.ten = Console.ReadLine();

            int N;
            Console.WriteLine("Nhap so luong NVVP: ");
            N = int.Parse(Console.ReadLine());
            this.dsNVVP = new NVVP[N];
            for (int i=0; i<this.dsNVVP.Length; i++)
            {
                this.dsNVVP[i] = new NVVP();
                this.dsNVVP[i].NhapNhanVien($"Nhap NVVP thu {i + 1}: ");
            }

            int M;
            Console.WriteLine("Nhap so luong NVSX: ");
            M = int.Parse(Console.ReadLine());
            this.dsNVSX = new NVSX[M];
            for (int i = 0; i < this.dsNVSX.Length; i++)
            {
                this.dsNVSX[i] = new NVSX();
                this.dsNVSX[i].NhapNhanVien($"Nhap NVSX thu {i + 1}: ");
            }
        }

        public double TinhTongLuong()
        {
            double S = 0;
            for (int i = 0; i < this.dsNVVP.Length; i++)
            {
                S += this.dsNVVP[i].TinhLuong();
            }
            for (int i = 0; i < this.dsNVSX.Length; i++)
            {
                S += this.dsNVSX[i].TinhLuong();
            }
            return S;
        }

    }
}
