using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct DaGiac
    {
        public Diem[] dsDinh;
    }
    public class XuLyDaGiac
    {
        public static DaGiac TaoDaGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            DaGiac kq;
            Console.WriteLine("Nhap so luong dinh: ");
            int N = int.Parse(Console.ReadLine());
            kq.dsDinh = new Diem[N];
            for (int i = 0; i < kq.dsDinh.Length; i++)
            {
                kq.dsDinh[i] = XuLyDiem.NhapDiem($"Nhap diem A[{i}]");
            }
            return kq;
        }
        public static double ChuViDaGiac(DaGiac kq)
        {
            double chuVi = 0;
            for (int i = 0; i<  kq.dsDinh.Length - 1; i++)
            {
                chuVi = chuVi + XuLyDiem.TinhKhoangCachGiuaHaiDiem(kq.dsDinh[i], kq.dsDinh[i + 1]);
            }
            chuVi = chuVi + XuLyDiem.TinhKhoangCachGiuaHaiDiem(kq.dsDinh[0], kq.dsDinh[kq.dsDinh.Length - 1]);

            return chuVi;
        }
    }
}
