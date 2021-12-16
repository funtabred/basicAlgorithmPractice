using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;
    }

    public class XuLyTamGiac
    {
        public static TamGiac TaoTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            TamGiac kq;
            kq.A = XuLyDiem.NhapDiem("Nhap diem A: ");
            kq.B = XuLyDiem.NhapDiem("Nhap diem B: ");
            kq.C = XuLyDiem.NhapDiem("Nhap diem C: ");
            return kq;
        }
        public static double TinhChuViTamGiac(TamGiac ABC)
        {
            double AB = XuLyDiem.TinhKhoangCachGiuaHaiDiem(ABC.A, ABC.B);
            double BC = XuLyDiem.TinhKhoangCachGiuaHaiDiem(ABC.C, ABC.B);
            double AC = XuLyDiem.TinhKhoangCachGiuaHaiDiem(ABC.A, ABC.C);
            double ChuVi = AB + BC + AC;
            return ChuVi;
        }
        public static double TinhDienTichTamGiac(TamGiac ABC)
        {
            VectorDuongThang AB = XuLyDiem.VectorGiuaHaiDiem(ABC.A, ABC.B);
            VectorDuongThang AC = XuLyDiem.VectorGiuaHaiDiem(ABC.A, ABC.C);
            double area = Math.Abs((AB.X * AC.Y) - (AC.X * AB.Y)) / 2;
            return area;
        }
        public static Diem TrongTamTamGiac(TamGiac ABC)
        {
            Diem G;
            G.X = (ABC.A.X + ABC.B.X + ABC.C.X) / 3;
            G.Y = (ABC.A.Y + ABC.B.Y + ABC.C.Y) / 3;
            return G;
        }
    }
}
