using System;
namespace oop_programming
{
    public class NHANVIEN
    {
        // Thanh phan du lieu
        private string ma;
        private string ten;
        private string diaChi;

        // Constructor
        public NHANVIEN()
        {

        }
        public NHANVIEN(string maNV, string tenNV, string diaChiNV)
        {
            this.ma = maNV;
            this.ten = tenNV;
            this.diaChi = diaChiNV;
        }

        // Properties
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        // Thanh phan xu li
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ten nhan vien: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nhan vien: ");
            this.diaChi = Console.ReadLine();
        }
    }
}
