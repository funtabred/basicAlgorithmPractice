using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    class XL_NguyenTo
    {
        public static bool KiemTraNguyenTo(int N)
        {
            if (N <= 1)
                return false;

            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    return false;
            }

            return true;
        }
        public static int NhapSoNguyen(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        public static int LamTronXuong(double d)
        {
            return (int)Math.Floor(d);
        }
        public static int Cong2SoNguyen(int a, int b)
        {
            return a + b;
        }


        public static int LamTronLen(double d)
        {
            return (int)Math.Ceiling(d);
        }
        public static int TimSoDao(int N)
        {
            if (N < 0)
            {
                N = -N;
            }

            int M = 0;
            while (N > 0)
            {
                int d = N % 10;
                M = M * 10 + d;
                N = N / 10;
            }
            return M;
        }
        public static bool KiemTraTinhDoiXung(int N)
        {
            return TimSoDao(N) == N;
        }

        public static bool KiemTraSoHoanThien(int N)
        {
            int i = 1;
            int S = 0;
            bool perfectNum = true;
            while (i < N)
            {
                if (N % i == 0)
                {
                    S = S + i;
                }
                i++;
            }
            if (S == N)
                perfectNum = true;
            else
                perfectNum = false;

            return perfectNum;
        }
        public static int UocChungLonNhat(int N, int M)
        {
            if (N == 0)
            {
                return M;
            }
            return UocChungLonNhat(M % N, N);
        }

        public static bool KiemTraSoNguyen(int N)
        {
            if (N % 1 != 0)
                return false;
            return true;
        }

        public static bool KiemTraSoChan(int N)
        {
            if (N == 0)
                return false;
            if (N % 2 != 0)
                return false;
            return true;
        }
        public static bool KiemTraTraiDau(int N, int M)
        {
            if (N == 0 || M == 0)
                return false;
            else if (N * M < 0)
                return true;
            return false;
        }

        public static bool KiemTraSoChinhPhuong(int N)
        {
            double result = Math.Sqrt(N);
            if (result % 1 == 0)
                return true;
            return false;
        }

        public static bool KiemTraSoToanChuSoLe(int N)
        //1. Extract every digit from the number
        //2. If the product of all those digits is odd, they are all odd.
        {
            int temp = N;
            int P = 1;
            while (temp > 0)
            {
                int d = temp % 10;
                temp = temp / 10;
                P = P * d;
            }
            if (P % 2 == 1)
                return true;
            return false;
        }        
    }
}
