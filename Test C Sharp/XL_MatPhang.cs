using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct Diem
    {
        public double X;
        public double Y;
    }
    public struct VectorDuongThang
    {
        public double X;
        public double Y;
    }
    public class XuLyDiem
    {
        public static Diem NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Diem kq;
            kq.X = XL_NguyenTo.NhapSoNguyen("Nhap hoanh do X: ");
            kq.Y = XL_NguyenTo.NhapSoNguyen("Nhap hoanh do Y: ");
            return kq;
        }
            
        public static void XuatDiem(Diem diem)
        {
            Console.Write($"({diem.X}, {diem.Y})");
        }
        public static double TinhKhoangCachGiuaHaiDiem(Diem A, Diem B)
        {

            double distance = Math.Sqrt((Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
            return distance;
        }
        public static VectorDuongThang VectorGiuaHaiDiem(Diem A, Diem B)
        {
            VectorDuongThang AB;
            AB.X = B.X - A.X;
            AB.Y = B.Y - A.Y;
       
            return AB;
        }

        public static double KhoangCachGiuaHaiDiemTheoPhuongOx(Diem A, Diem B)
        {
            return Math.Sqrt((Math.Pow(B.X - A.X, 2)));
        }

        public static double KhoangCachGiuaHaiDiemTheoPhuongOy(Diem A, Diem B)
        {
            return Math.Sqrt((Math.Pow(B.Y - A.Y, 2)));
        }

        public static Diem DiemDoiXungQuaGocToaDo(Diem A)
        {
            Diem B = new Diem();
            B.X = -A.X;
            B.Y = -A.Y;
            return B;
        }
    }
}
