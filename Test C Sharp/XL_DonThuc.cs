using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct DonThuc
    {
        public int a;
        public int n;
    }
    public class XL_DonThuc
    {
        public static DonThuc NhapDonThuc(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            DonThuc P;
            P.a = XL_NguyenTo.NhapSoNguyen("Nhap a: ");
            P.n = XL_NguyenTo.NhapSoNguyen("Nhap n: ");
            return P;
        }
        public static void XuatDonThuc(DonThuc P)
        {
            Console.WriteLine($"P(x) = {P.a}x^{P.n}");
        }
        public static DonThuc TichHaiDonThuc(DonThuc P, DonThuc F)
        {
            DonThuc T;
            T.a = P.a * F.a;
            T.n = P.n + F.n;
            return T;
        }
        public static DonThuc DaoHamCap1CuaDonThuc(DonThuc P)
        {
            DonThuc F;
            F.a = P.a * P.n;
            F.n = P.n - 1;
            return F;
        }
        public static DonThuc ThuongHaiDonThuc(DonThuc P, DonThuc F)
        {
            DonThuc T;
            T.a = P.a / F.a;
            T.n = P.n - F.n;
            return T;
        }
        public static DonThuc DaoHamCapKCuaDonThuc(DonThuc P, int k)
        {
            DonThuc F;
            F = DaoHamCap1CuaDonThuc(P);
            int i = 1;
            while (i < k)
            {
                F.a = F.a * (P.n - 1);
                P.n = P.n - 1;
                F.n = F.n - 1;
                i++;
            }
            return F;
        }
        public static double TinhGiaTriDonThuc(DonThuc P, double x)
        {
            return P.a * Math.Pow(x, P.n);
        }
        /*public static DonThuc operator (DonThuc P, DonThuc F)
        {
            DonThuc T;
            T.a = P.a * F.a;
            T.n = P.n + F.n;
            return T;
        }*/
    }

}
