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
            this.loaiNhanVien = LOAINHANVIEN.NhanVienSanXuat;
        }


        
        // Thanh phan xu li
        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Console.WriteLine("Nhap so luong san pham: ");
            this.soLuongSP = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return this.soLuongSP * 10;
        }

        // Vi du ve ham ao
        // Cai dat lai ham F cua NHANVIEN
        
        public new void F()
        {
            Console.WriteLine("Ham F cua lop NXSX");
        }

        public override void F_AO()
        {
            Console.WriteLine("Ham F_AO cua lop NVSX");
        }
    }
}
