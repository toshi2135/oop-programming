using System;

namespace HDT.Entities
{
    public class PhanSo
    {
        // Thanh phan du lieu
        private int _mauSo;
        public int TuSo { get; set; }
        public int MauSo
        {
            get
            {
                return this._mauSo;
            }
            set
            {
                if (value != 0)
                {
                    this._mauSo = value;
                }
                else
                {
                    throw new Exception("Mau so khong duoc = 0");
                }
            }
        }

        // Thanh phan xu li
        // Ham tao (constructor)
        public PhanSo()
        {
            this.TuSo = 0;
            this._mauSo = 1;
        }

        public PhanSo(int t)
        {
            this.TuSo = t;
            this._mauSo = 1;
        }

        public PhanSo(int t, int m)
        {
            this.TuSo = t;
            if (m != 0)
            {
                this._mauSo = m;
            }
            else
            {
                this._mauSo = 1;
            }
        }

        public PhanSo CongPhanSo(PhanSo b)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.TuSo = this.TuSo * b.MauSo + this.MauSo * b.TuSo;
            kq.MauSo = this.MauSo * b.MauSo;

            return kq;
        }
        public string Xuat()
        {
            return $"{this.TuSo}/{this.MauSo}";
        }
    }
}
