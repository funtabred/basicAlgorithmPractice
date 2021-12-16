using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct HonSo
    {
        public int CoSo;
        public PhanSo PhanPhanSo;
    }
    public class XL_HonSo
    {
        public static HonSo NhapHonSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            HonSo A;
            Console.WriteLine("Nhap co so: ");
            A.CoSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tu so: ");
            A.PhanPhanSo.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            A.PhanPhanSo.MauSo = int.Parse(Console.ReadLine());

            return A;
        }
        public static void XuatHonSo(HonSo A)
        {
            Console.WriteLine($"{A.CoSo} {A.PhanPhanSo.TuSo}/{A.PhanPhanSo.MauSo}");
        }
        public static PhanSo ChuyenHonSoVePhanSo(HonSo A)
        {
            PhanSo B;
            B.TuSo = A.CoSo * A.PhanPhanSo.MauSo + A.PhanPhanSo.TuSo;
            B.MauSo = A.PhanPhanSo.MauSo;
            return B;
        }
        public static HonSo RutGonHonSo(HonSo A)
        {
            HonSo B = new HonSo();
            if (A.PhanPhanSo.TuSo / B.PhanPhanSo.MauSo > 0)
            {
                B.CoSo = A.CoSo + A.PhanPhanSo.TuSo / A.PhanPhanSo.MauSo;
                B.PhanPhanSo.TuSo = A.PhanPhanSo.TuSo % A.PhanPhanSo.MauSo;
                B.PhanPhanSo.MauSo = A.PhanPhanSo.MauSo;
            }
            return B;            
        }
        public static HonSo TongHaiHonSo(HonSo A, HonSo B)
        {
            PhanSo tempA;
            PhanSo tempB;
            PhanSo tempC;
            tempA.TuSo = A.CoSo * A.PhanPhanSo.MauSo + A.PhanPhanSo.TuSo;
            tempA.MauSo = A.PhanPhanSo.MauSo;
            tempB.TuSo = B.CoSo * B.PhanPhanSo.MauSo + B.PhanPhanSo.TuSo;
            tempB.MauSo = B.PhanPhanSo.MauSo;
            tempC = XuLyPhanSo.TongHaiPhanSo(tempA, tempB);
            HonSo C;
            C.CoSo = tempC.TuSo / tempC.MauSo;
            C.PhanPhanSo.TuSo = tempC.TuSo % tempC.MauSo;
            C.PhanPhanSo.MauSo = tempC.MauSo;            
            return C;
        }
        public static HonSo HieuHaiHonSo(HonSo A, HonSo B)
        {
            PhanSo tempA = ChuyenHonSoVePhanSo(A);
            PhanSo tempB = ChuyenHonSoVePhanSo(B);       
            PhanSo tempC = XuLyPhanSo.HieuHaiPhanSo(tempA, tempB);
            HonSo C;
            C.CoSo = tempC.TuSo / tempC.MauSo;
            C.PhanPhanSo.TuSo = tempC.TuSo % tempC.MauSo;
            C.PhanPhanSo.MauSo = tempC.MauSo;
            return C;
        }
        public static HonSo TichHaiHonSo(HonSo A, HonSo B)
        {
            PhanSo tempA = ChuyenHonSoVePhanSo(A);
            PhanSo tempB = ChuyenHonSoVePhanSo(B);
            PhanSo tempC = XuLyPhanSo.TichHaiPhanSo(tempA, tempB);
            HonSo C;
            C.CoSo = tempC.TuSo / tempC.MauSo;
            C.PhanPhanSo.TuSo = tempC.TuSo % tempC.MauSo;
            C.PhanPhanSo.MauSo = tempC.MauSo;
            return C;
        }
        public static HonSo ThuongHaiHonSo(HonSo A, HonSo B)
        {
            PhanSo tempA = ChuyenHonSoVePhanSo(A);
            PhanSo tempB = ChuyenHonSoVePhanSo(B);
            PhanSo tempC = XuLyPhanSo.ThuongHaiPhanSo(tempA, tempB);
            HonSo C;
            C.CoSo = tempC.TuSo / tempC.MauSo;
            C.PhanPhanSo.TuSo = tempC.TuSo % tempC.MauSo;
            C.PhanPhanSo.MauSo = tempC.MauSo;
            return C;
        }
        public static bool KiemTraHonSoToiGian(HonSo A)
        {
            if (XL_NguyenTo.UocChungLonNhat(A.PhanPhanSo.TuSo, A.PhanPhanSo.MauSo) == 1)
                return true;
            else
                return false;
        }
        public static HonSo ChuyenPhanSoVeHonSo(PhanSo A)
        {
            HonSo B;
            B.CoSo = A.TuSo / A.MauSo;
            B.PhanPhanSo.TuSo = A.TuSo % A.MauSo;
            B.PhanPhanSo.MauSo = A.MauSo;
            return B;
        }
        public static HonSo[] QuyDongHaiHonSo(HonSo A, HonSo B)
        {
            HonSo[] arr = new HonSo[2];
            if (A.PhanPhanSo.MauSo == B.PhanPhanSo.MauSo)
            { arr[0] = A; arr[1] = B; }
            else
            {
                PhanSo tempA = ChuyenHonSoVePhanSo(A);
                PhanSo tempB = ChuyenHonSoVePhanSo(B);
                tempA.TuSo = tempA.TuSo * tempB.MauSo;
                tempA.MauSo = tempA.MauSo * tempB.MauSo;
                tempB.TuSo = tempB.TuSo * tempA.MauSo;
                tempB.MauSo = tempB.MauSo * tempA.MauSo;
                arr[0] = ChuyenPhanSoVeHonSo(tempA);
                arr[1] = ChuyenPhanSoVeHonSo(tempB);
            }
            return arr;
        }       
    }
}
