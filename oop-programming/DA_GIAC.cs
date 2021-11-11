using System;
namespace oop_programming
{
    public class DA_GIAC
    {
        // Thanh phan du lieu
        public TOA_DO[] dsDinh;

        // Thanh phan xu li
        public void NhapSoDinh(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dinh N: ");
            int n = int.Parse(Console.ReadLine());
            this.dsDinh = new TOA_DO[n];
            for (int i=0; i < this.dsDinh.Length; i++)
            {
                this.dsDinh[i] = new TOA_DO();
                this.dsDinh[i].Nhap($"Nhap diem A[{i}]: ");
            }
        }

        public double TinhChuVi()
        {
            double kq = 0;
            for (int i=0; i<this.dsDinh.Length-1; i++)
            {
                kq += this.dsDinh[i].TinhKhoangCach(this.dsDinh[i + 1]);
            }
            kq += this.dsDinh[0].TinhKhoangCach(this.dsDinh[dsDinh.Length - 1]); ;

            return kq;
        }
    }
}
