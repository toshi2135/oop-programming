using System;
using System.Collections.Generic;

namespace oop_programming
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

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
            /*
            // B1. Khai bao & tao lap doi tuong
            PHAN_SO a, b; // Khai bao
            a = new PHAN_SO(); // Tao lap
            b = new PHAN_SO();

            // B2. Yeu cau doi tuong thuc hien hanh dong
            a.Nhap("Nhap phan so a: ");
            b.Nhap("Nhap phan so b: ");

            PHAN_SO s;
            s = new PHAN_SO();
            s = a.CongPhanSo(b);
            string chuoi = "Ket qua la " + s.Xuat();
            Console.WriteLine(chuoi);
            */

            // Tinh khoang cach 2 diem/toa do - OOP
            /*
            TOA_DO a, b;
            a = new TOA_DO();
            b = new TOA_DO();

            a.Nhap("Nhap diem A: ");
            b.Nhap("Nhap diem B: ");

            double kq = a.TinhKhoangCach(b);
            string chuoi = "Ket qua la " + kq;
            Console.WriteLine(chuoi);
            */

            // Tinh chu vi tam giac 3 diem/toa do - functional
            /*
            TOA_DO A, B, C;
            A = new TOA_DO();
            B = new TOA_DO();
            C = new TOA_DO();

            A.Nhap("Nhap diem A: ");
            B.Nhap("Nhap diem B: ");
            C.Nhap("Nhap diem C: ");

            double AB, AC, BC;
            AB = A.TinhKhoangCach(B);
            BC = B.TinhKhoangCach(C);
            AC = C.TinhKhoangCach(A);
            double kq = AB + BC + AC;
            string chuoi = "Chu vi tam giac la " + kq;
            Console.WriteLine(chuoi);
            */

            // Tinh chu vi tam giac 3 diem/toa do - OOP
            /*
            TAM_GIAC ABC;
            ABC = new TAM_GIAC();
            ABC.NhapTamGiac("Nhap tam giac ABC: ");
            string chuoi = "Chu vi tam giac la " + ABC.TinhChuVi();
            Console.WriteLine(chuoi);
            */

            // Tinh chu vi da giac n diem/toa do - OOP
            /*
            DA_GIAC XYZ;
            XYZ = new DA_GIAC();
            XYZ.NhapSoDinh("Nhap da giac XYZ: ");
            string chuoi = "Chu vi da giac la " + XYZ.TinhChuVi();
            Console.WriteLine(chuoi);
            */

            // Nhap thong tin CONGTY, tinh tong luong
            /*
            CONGTY ct = new CONGTY();
            ct.NhapCty("Nhap thong tin cong ty: ");
            double kq = ct.TinhTongLuong();
            Console.WriteLine(kq);
            */

            // Tinh da hinh
            // NVSX sx;
            // NVSX sx = new NVSX();
            // sx.F_AO();
            /*
            NHANVIEN nv;

            nv = new NVSX();
            nv.F();
            nv.F_AO();

            nv = new NVVP();
            nv.F();
            nv.F_AO();
            */

            // Nhap thong tin MATPHANG, tinh tong chu vi
            /*
            MATPHANG mp = new MATPHANG();
            mp.Nhap("Nhap thong tin: ");
            double kq = mp.TinhTongChuVi();
            Console.WriteLine(kq);
            */

            // Enums

            // Exceptions
            /*
            int a, b;
            a = 9;
            b = 0;
            try
            {
                double kq = a / b;
                Console.WriteLine(kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Co loi: " + ex.Message);
            }
            */

            // Tu tao Exception
            /*
            PHAN_SO t = new PHAN_SO();
            try
            {
                t.TU_SO_GON = 2;
                t.MAU_SO = 0;
            }
            catch (MyException ex)
            {
                Console.WriteLine("Khong gan duoc vi mau so = 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Co loi: " + ex.Message);
            }
            */

            // Generic
            /*
            List<PHAN_SO> A = new List<PHAN_SO>();
            List<int> Aint = new List<int>();
            */
            MyGenericArray<int> a = new MyGenericArray<int>(5);
            a.setItem(0, 5);
            int t = a.getItem(0);

            MyGenericArray<TOA_DO> b = new MyGenericArray<TOA_DO>(5);
            b.setItem(0, new TOA_DO());
            TOA_DO d = b.getItem(0);
        }
    }
}
