using System;
namespace oop_programming
{
    // Khai bao du lieu
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }
    public class XL_PHANSO
    {
        // Cac ham lien quan xu ly phan so
        public static PHANSO NhapPhanSo(string ghiChu)
        {
            PHANSO kq;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }

        public static PHANSO TinhTongPhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static string Xuat(PHANSO a)
        {
            return $"{a.TuSo}/{a.MauSo}";
        }
    }
}
