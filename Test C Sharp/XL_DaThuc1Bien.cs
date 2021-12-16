using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct DaThuc1Bien
    {
        public int a;
        public int n;
    }
    public class XL_DaThuc1Bien
    {
        public static DaThuc1Bien NhapDaThuc(string ghiChu)
        {
            Console.WriteLine("Tao da thuc 1 bien: ");
            DaThuc1Bien P;
            P.a = XL_NguyenTo.NhapSoNguyen("Nhap a: ");
            P.n = XL_NguyenTo.NhapSoNguyen("Nhap n: ");
            return P;
        }
        public static void XuatDaThuc1Bien(DaThuc1Bien P)
        {
            int i = P.n;
            Console.Write("P(x) = ");
            Console.Write($"{P.a}*{i}x^{i}");
            while (i > 0)
            {                
                Console.Write($" + {P.a}*{i - 1}x^{i - 1}");
                i--;
            }
        }
        /*public static DaThuc1Bien HieuHaiDaThuc(DaThuc1Bien P, DaThuc1Bien F) //Bai 493
        {
            DaThuc1Bien result;
            int i = P.n;
            if (P.n == F.n)
            {
                result.a = P.a - F.a;
                result.n = P.n;
            }
            if (P.n != F.n)
            {
                if (P.n > F.n)
                {
                    
                }
            }
        }*/

    }
}
