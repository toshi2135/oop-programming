using System;
namespace oop_programming
{
    public class NVVP
    {
        // Thanh phan du lieu
        private string ma;
        private string ten;
        private string diaChi;
        private int phuCap;
        private double heSo;

        // Constructor
        public NVVP(string maNV, string tenNV, string diaChiNV, int phuCapNV, double heSoNV)
        {
            this.ma = maNV;
            this.ten = tenNV;
            this.diaChi = diaChiNV;
            this.phuCap = phuCapNV;
            this.heSo = heSoNV;
        }

        // Properties
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public int PhuCap
        {
            get { return phuCap; }
            set { phuCap = value; }
        }
        public double HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }

        // Thanh phan xu li
        public void NhapNhanVien(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ten nhan vien: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nhan vien: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap phu cap: ");
            this.phuCap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            this.heSo = double.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return this.heSo * 10 + this.phuCap;
        }
    }
}
