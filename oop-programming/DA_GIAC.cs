using System;
namespace oop_programming
{
    public class DA_GIAC
    {
        // Thanh phan du lieu
        public int n;

        // Thanh phan xu li
        public void NhapSoDinh(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dinh N: ");
            this.n = int.Parse(Console.ReadLine());
        }
    }
}
