using System;
namespace oop_programming
{
    public class NVSX : NHANVIEN
    {
        // Thanh phan du lieu
        private int soLuongSP;

        // Constructor
        public NVSX()
        {

        }
        public NVSX(string maNV, string tenNV, string diaChiNV, int soLuongSPNV) : base(maNV, tenNV, diaChiNV)
        {
            this.soLuongSP = soLuongSPNV;
        }

        // Properties
        public int SoLuongSP { get; set; }
        
        // Thanh phan xu li
        public void NhapNhanVien (string ghiChu)
        {
            this.Nhap(ghiChu);
            Console.WriteLine("Nhap so luong san pham: ");
            this.soLuongSP = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return this.SoLuongSP * 10;
        }
    }
}
