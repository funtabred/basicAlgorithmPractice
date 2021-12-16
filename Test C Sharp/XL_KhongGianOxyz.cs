using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct KhongGianOxyz
    {
        public int X;
        public int Y;
        public int Z;
    }

    public class XuLyKhongGianOxyz
    {
        public static KhongGianOxyz NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            KhongGianOxyz A;
            A.X = XL_NguyenTo.NhapSoNguyen("Nhap hoanh do x: ");
            A.Y = XL_NguyenTo.NhapSoNguyen("Nhap tung do y: ");
            A.Z = XL_NguyenTo.NhapSoNguyen("Nhap cao do z: ");
            return A;
        }
        public static void XuatDiem(KhongGianOxyz A)
        {
            Console.WriteLine($"({A.X}, {A.Y}, {A.Z}");
        }
    }

}
