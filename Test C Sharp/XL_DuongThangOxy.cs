using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct DuongThang
    {
        public int a;
        public int b;
        public int c;
    }
    public class XL_DuongThang
    {
        public static DuongThang TaoDuongThang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            DuongThang AB;
            AB.a = XL_NguyenTo.NhapSoNguyen("Nhap a: ");
            AB.b = XL_NguyenTo.NhapSoNguyen("Nhap b: ");
            AB.c = XL_NguyenTo.NhapSoNguyen("Nhap c: ");
            return AB;
        }
        public static void XuatDuongThang(DuongThang AB)
        {
            Console.WriteLine($"{AB.a}x + {AB.b}y + {AB.c} = 0");
        }
    }
}
