using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct CHITIETDONHANG
    {
        public string tenMatHang;
        public int soLuong;
        public int donGia;
    }
    public struct DONHANG
    {
        public string tenCuaHang;
        public string tenKhachHang;
        public CHITIETDONHANG[] donHang;
    }
    class GiaiDe
    {
        //De 1
        public static void GiaiPhuongTrinhBac1(int a, int b)
        {
            Console.WriteLine("Nhap X");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine($"P(X) = {a * X + b}");
        }

        public static int TimSoDao(int A)
        {
            if (A < 0)
            {
                A = -A;
            }
            int M = 0;
            while (A > 0)
            {
                int temp = A % 10;
                M = M* 10 + temp;
                A = A / 10;
            }
            return M;
        }
        public static bool KiemtraSoDoiXung(int A)
        {
            if (TimSoDao(A) == A)
            {
                return true;
            }
            else
                return false;
        }

        public static int TimSoDoiXungNhoNhat(int[] A)
        {
            int min = 0;
            int minIndex = new int();
            for (int i = 0; i < A.Length; i++)
            {
                if (KiemtraSoDoiXung(A[i]) == true)
                {
                    minIndex = i;
                    min = A[i];
                }
            }
            for (int i = minIndex + 1; i < A.Length; i++)
            {
                if (KiemtraSoDoiXung(A[i]) == true && A[i] < min)
                {
                    min = A[i];
                }
            }
            return min;
        }

        //Bai 3
        public static DONHANG NhapDonHang(string ghiCHu)
        {
            Console.WriteLine(ghiCHu);
            DONHANG A = new DONHANG();

            Console.WriteLine("Nhap ten cua hang");
            A.tenCuaHang = Console.ReadLine();

            Console.WriteLine("Nhap ten khach hang");
            A.tenKhachHang = Console.ReadLine();

            Console.WriteLine("Nhap so luong don hang");
            int number = int.Parse(Console.ReadLine());

            A.donHang = new CHITIETDONHANG[number];

            Console.WriteLine("Nhap chi tiet don hang:");
            for(int i = 0; i < A.donHang.Length; i ++)
            {
                Console.WriteLine($"Don so {i+1}:");

                Console.WriteLine("Ten mat hang:");
                A.donHang[i].tenMatHang = Console.ReadLine();

                Console.WriteLine("So luong: ");
                A.donHang[i].soLuong = int.Parse(Console.ReadLine());

                Console.WriteLine("Don gia: ");
                A.donHang[i].donGia = int.Parse(Console.ReadLine());
            }

            return A;
        }

        public static void XuatChiTietDonHang (CHITIETDONHANG A)
        {
            Console.WriteLine($"Ten mat hang gia tri lon nhat: {A.tenMatHang}");
            Console.WriteLine($"Don gia: {A.donGia}");
            Console.WriteLine($"So luong: {A.soLuong}");
            Console.WriteLine($"Thanh tien: {A.soLuong * A.donGia}");
            
        }

        public static CHITIETDONHANG TimChiTietDonHangLonNhat(DONHANG d)
        {
            int maxOrderIndex = 0;
            for (int i = 0; i < d.donHang.Length - 1; i++)
            {
                if (d.donHang[i].donGia*d.donHang[i].soLuong > d.donHang[i+1].donGia*d.donHang[i+1].soLuong)
                {
                    maxOrderIndex = i;
                }
            }
            return d.donHang[maxOrderIndex];
        }
    }

}
