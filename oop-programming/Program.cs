using System;

namespace oop_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viet duoi dang Ham (functional)

            /*
            PHANSO a, b;
            a = XL_PHANSO.NhapPhanSo("Nhap phan so a:");
            b = XL_PHANSO.NhapPhanSo("Nhap phan so b:");

            PHANSO s;
            s = XL_PHANSO.TinhTongPhanSo(a, b);

            string chuoi = "Ket qua la " + XL_PHANSO.Xuat(s);

            Console.WriteLine(chuoi);
            */

            // Viet duoi dang HDT (oop)

            // B1. Khai bao & tao lap doi tuong
            PHAN_SO a, b; // Khai bao
            a = new PHAN_SO(); // Tao lap
            b = new PHAN_SO();

            // B2. Yeu cau doi tuong thuc hien hanh dong
            a.Nhap("Nhap phan so a: ");
            b.Nhap("Nhap phan so b: ");

            // PHAN_SO s;
            // s = a.CongPhanSo(b);
            // string chuoi = "Ket qua la " + s.Xuat();
            // Console.WriteLine(chuoi);
        }
    }
}
