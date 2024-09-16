using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Buoi4
{
    internal class Singvien
    {


        string MSSV;
        public void setMSSV(string MSSV)
        {
            this.MSSV = MSSV;
        }
        public string getMSSV()
        {
            return this.MSSV;
        }
        string hoTen;
        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string getHoTen()
        {
            return hoTen;
        }

        string gioiTinh;
        public void setGioiTinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
        }
        public string getGioiTinh()
        {
            return gioiTinh;
        }
        DateTime ngaySinh;
        public void setngaysinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }
        string diaChi;
        public void setDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string getDiaChi()
        {
            return diaChi;
        }
        // Viết hàm khỏi tạo:
        // Hàm khởi tạo ko có tham số:
        public Singvien() { }

        // hàm khởi tạo có tham số:
        public Singvien(string mSSV, string hoTen, DateTime ngaySinh, string diaChi, string gioiTinh)
        {
            this.MSSV = mSSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
        }
    }
}
