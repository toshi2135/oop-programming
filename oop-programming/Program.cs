using System;

namespace oop_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            PHANSO a, b;
            a = XL_PHANSO.NhapPhanSo("Nhap phan so a:");
            b = XL_PHANSO.NhapPhanSo("Nhap phan so b:");

            PHANSO s;
            s = XL_PHANSO.TinhTongPhanSo(a, b);

            string chuoi = "Ket qua la " + XL_PHANSO.Xuat(s);

            Console.WriteLine(chuoi);
        }
    }
}
