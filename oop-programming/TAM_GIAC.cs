using System;
namespace oop_programming
{
    public class TAM_GIAC
    {
        // Thanh phan du lieu
        public TOA_DO A, B ,C;

        // Thanh phan xu li
        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new TOA_DO();
            this.A.Nhap("Nhap diem A: ");
            this.B = new TOA_DO();
            this.B.Nhap("Nhap diem B: ");
            this.C = new TOA_DO();
            this.C.Nhap("Nhap diem C: ");
        }

        public double TinhChuVi()
        {
            double AB, BC, AC;
            AB = this.A.TinhKhoangCach(B);
            BC = this.B.TinhKhoangCach(C);
            AC = this.C.TinhKhoangCach(A);
            return AB + BC + AC;
        }
    }
}
