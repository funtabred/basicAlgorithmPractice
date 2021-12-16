using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    
    public struct PhanSo
    {
         public int TuSo;
         public int MauSo;
    }
    public class XuLyPhanSo
    {
        public static PhanSo NhapPhanSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            PhanSo kq;
            kq.TuSo = XL_NguyenTo.NhapSoNguyen("Nhap tu so: ");
            kq.MauSo = XL_NguyenTo.NhapSoNguyen("Nhap mau so: ");
            return kq;
        }
        public static void XuatPhanSo(PhanSo p)
        {
            Console.Write($"{p.TuSo}/{p.MauSo}");
        }
        public static PhanSo TongHaiPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo kq;
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static PhanSo RutGonPhanSo(PhanSo A)
        {
            PhanSo B;
            int i = XL_NguyenTo.UocChungLonNhat(A.TuSo, A.MauSo);
            B.MauSo = A.MauSo / i;
            B.TuSo = A.TuSo / i;
            return B;
        }
        public static PhanSo HieuHaiPhanSo(PhanSo A, PhanSo B)
        {
            PhanSo result;
            if (A.MauSo == B.MauSo)
            {
                result.TuSo = A.TuSo - B.TuSo;
                result.MauSo = A.MauSo;
            }
            else
            {
                result.TuSo = A.TuSo * B.MauSo - B.TuSo * A.MauSo;
                result.MauSo = A.MauSo * B.MauSo;
            }
            RutGonPhanSo(result);
            return result;
        }
        public static PhanSo TichHaiPhanSo(PhanSo A, PhanSo B)
        {
            PhanSo result;
            result.TuSo = A.TuSo * B.MauSo;
            result.MauSo = A.MauSo * B.MauSo;
            RutGonPhanSo(result);
            return result;
        }
        public static PhanSo ThuongHaiPhanSo(PhanSo A, PhanSo B)
        {
            PhanSo result;
            result.TuSo = A.TuSo * B.MauSo;
            result.MauSo = A.MauSo * B.TuSo;
            RutGonPhanSo(result);
            return result;
        }
        public static bool KiemTraToiGian(PhanSo A)
        {            
            if (XL_NguyenTo.UocChungLonNhat(A.TuSo, A.MauSo) == 1)
                return true;
            return false;            
        }
        public static PhanSo[] QuyDongHaiPhanSo(PhanSo A, PhanSo B)
        {
            PhanSo[] QuyDong = new PhanSo[2];
            QuyDong[0] = A;
            QuyDong[1] = B;
            if (A.MauSo != B.MauSo)
            {             
                QuyDong[0].TuSo = A.TuSo * B.MauSo;
                QuyDong[0].MauSo = A.MauSo * B.MauSo;
                QuyDong[1].TuSo = B.TuSo * A.MauSo;
                QuyDong[1].MauSo = B.MauSo * A.MauSo;
            }
            return QuyDong;
        }
        public static bool KiemTraPhanSoDuong(PhanSo A)
        {
            if (A.MauSo * A.TuSo == 0)
                return false;            
            else if (A.MauSo * A.TuSo < 0)            
                return false;            
            else
                return true;            
        }
        public static bool KiemTraPhanSoAm(PhanSo A)
        {
            if (A.MauSo * A.TuSo == 0)
                return false;
            else if (A.MauSo * A.TuSo < 0)
                return true;
            else
                return false;
        }
        public static int SoSanhPhanSo(PhanSo A, PhanSo B)
        {            
            PhanSo[] arr = QuyDongHaiPhanSo(A, B);
            if (arr[0].TuSo > arr[1].TuSo)
                return 1;
            else if (arr[0].TuSo < arr[1].TuSo)
                return -1;
            else
                return 0;
        }
        /*public static PhanSo operator +(PhanSo A, PhanSo B)
        {
            PhanSo C = new PhanSo();
            C.TuSo = A.TuSo * B.MauSo + B.TuSo * A.MauSo;
            C.MauSo = A.MauSo * B.MauSo;
            RutGonPhanSo(C);
            return C;
        }*/
    }   
}
