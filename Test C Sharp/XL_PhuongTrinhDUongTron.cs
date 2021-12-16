using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct DuongTron
    {
        public Diem center;
        public double radius;
    }
    public class XL_DuongTron
    {
        public static DuongTron TaoDuongTron(string note)
        {
            Console.WriteLine(note);
            DuongTron O;
            O.center = XuLyDiem.NhapDiem("Nhap tam duong tron: ");
            O.radius = XL_SoThuc.NhapSoThuc("Nhap ban kinh: ");
            return O;
        }
        public static void XuatPhuongTrinhDuongTron(DuongTron O)
        {
            Console.WriteLine($"(x - {O.center.X})^2 + (y - {O.center.Y})^2 = {Math.Pow(O.radius, 2)}");
        }
        public static double ChuViDuongTron(DuongTron O)
        {
            double perimeter = 2 * O.radius * Math.PI;
            return perimeter;
        }
        public static double DienTichDuongTron(DuongTron O)
        {
            double area = Math.PI * O.radius;
            return area;
        }
    }
}
