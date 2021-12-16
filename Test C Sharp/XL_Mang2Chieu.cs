using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    class XL_Mang2Chieu
    {
        public static int[,] NhapMaTran(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            int[,] A;
            //Nhap ma tran
            Console.WriteLine("Nhap so dong: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            int M = int.Parse(Console.ReadLine());
            A = new int[N, M];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        
        
        public static void XuatMaTran(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]}   ");
                }
                Console.WriteLine();
            }
        }      

        public static int TinhTong(int[,] A)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[i, j];
                }
            }
            return S;
        }

        public static int GiaTriLonNhat(int[,] A) //Bai 315
        {
            int max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static int GiaTriNhoNhat(int[,] A)
        {
            int min = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (min > A[i, j])
                    {
                        min = A[i, j];
                    }
                }
            }
            return min;
        }
        public static bool KiemTraGiaTriChanNhoHon2015(int[,] A) //Bai 316
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 2015)
                        return true;
                }
            }
            return false;
        }

        public static int DemSoNguyenTo(int[,] A) //Bai 317
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int TongGiaTriAm(int[,] A) //Bai 318
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                        S = S + A[i, j];
                }
            }
            return S;
        }
        public static void SapXepMaTran(int[,] A) //Bai 319
        {
            int N = A.GetLength(0) * A.GetLength(1);
            int M = A.GetLength(1);
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i / M, i % M] > A[j / M, j % M])
                    {
                        int temp = A[i / M, i % M];
                        A[i / M, i % M] = A[j / M, j % M];
                        A[j / M, j % M] = temp;
                    }
                }
            }
        }

        public static int TongGiaTriDuong(int[,] A) //Bai 320
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        S = S + A[i, j];
                }
            }
            return S;
        }

        public static int TichGiaTriLe(int[,] A) //Bai 321
        {
            int P = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1)
                        P = P * A[i, j];
                }
            }
            return P;
        }

        public static int TinhTongDong(int[,] A, int k) //Bai 322
        {
            int S = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                S = S + A[k, j];
            }
            return S;
        }

        public static int TinhTongCot(int[,] A, int k)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                S = S + A[i, k];
            }
            return S;
        }
        public static int TinhTichCot(int[,] A, int k) //Bai 323
        {
            int S = 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] > 0)
                    S = S * A[i, k];
            }
            return S;
        }
        public static int TinhTongDuongTrenDong(int[,] A, int k) //Bai 324
        {
            int S = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[k, j] > 0)
                    S = S + A[k, j];
            }
            return S;
        }
        public static int TinhTichSoChanTrenCot(int[,] A, int k) //Bai 325
        {
            int P = 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] % 2 == 0)
                    P = P * A[i, k];
            }
            return P;
        }
        public static double TrungBinhCongSoDuong(int[,] A) //Bai 326
        {
            double avg = 0;
            int count = 0;
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        S = S + A[i, j];
                        count++;
                    }
                }
            }
            avg = (S / count);
            return avg;
        }


        public static int TinhTongGiaTriBien(int[,] A) //Bai 327
        {
            //1. Calculate the first row
            //2. Calculate the last row if row length of the array is greater than one.
            //3. To calculate the sum of the boundaries in middle rows, use a for loop to go thru those rows but add only the bordered elements.

            int S;
            S = TinhTongDong(A, 0);
            if (A.GetLength(0) > 1)
            {
                S = S + TinhTongDong(A, A.GetLength(0) - 1);

            }
            for (int i = 1; i < A.GetLength(0) - 1; i++)
            {
                S = S + A[i, 0];
                if (A.GetLength(i) > 1)
                { S = S + A[i, A.GetLength(i) - 1]; }
            }
            return S;
        }

        public static double TrungBinhNhanSoDuong(int[,] A) //bai 328
        {
            double avg;
            double P = 1;
            double count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        P = P * A[i, j];
                        count++;
                    }
                }
            }
            avg = Math.Pow(P, (1 / count));
            return avg;
        }
        public static void ThaySoAmBangTriTuyetDoi(int[,] A) //Bai 329
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        A[i, j] = Math.Abs(A[i, j]);
                    }
                }
            }
            XL_Mang2Chieu.XuatMaTran(A);
        }
        public static void ThaySoThucBangSoNguyen(double[,] A) //Bai 330
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 1 != 0)
                    {
                        A[i, j] = Math.Round(A[i, j]);
                    }
                }
            }
            //XL_Mang2Chieu.XuatMaTran(A);
        }

        public static int TongGiaTriLe(int[,] A) //Bai 332
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1)
                        S = S + A[i, j];
                }
            }
            return S;
        }

        public static int TongSoHoanThien(int[,] A) //Bai 333
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoHoanThien(A[i, j]) == true)
                        S = S + A[i, j];
                }
            }
            return S;
        }

        public static int DemSoDuong(int[,] A) //Bai 334
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        count++;
                }
            }
            return count;
        }

        public static int TanSoXuatHienCuaX(int[,] A, int X) //Bai 336
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == X)
                        count++;
                }
            }
            return count;
        }

        public static int DemSoChuSo(int[,] A) //Bai 337
        {
            int count = 0;
            int temp;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    temp = A[i, j];
                    while (temp > 0)
                    {
                        temp = temp / 10;
                        count++;
                    }
                }
            }
            return count;
        }

        public static int DemSoDuongTrenMotHang(int[,] A, int k) //Bai 338
        {
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[k, j] > 0)
                    count++;
            }

            return count;
        }

        public static int DemSoHoanThienTrenMotHang(int[,] A, int k) //Bai 339
        {
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (XL_NguyenTo.KiemTraSoHoanThien(A[k, j]) == true)
                    count++;
            }

            return count;
        }

        public static int DemSoAmTrenMotCot(int[,] A, int k) //Bai 340
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] < 0)
                    count++;
            }

            return count;
        }
        public static int DemSoDuongTrenBien(int[,] A) //Bai 341
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if ((i == 0 || j == 0) || (i == A.GetLength(1) - 1 || j == A.GetLength(1) - 1) && A[i, j] > 0)
                    { count++; }
                }
            }
            return count;
        }
        public static int DemSoLuongPhanTuCucDai(int[,] A) //Bai 342
        {
            //
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    bool isOK = true;
                    for (int k = 0; k < 8; k++)
                    {
                        if (i + dx[k] >= 0 && i + dx[k] < A.GetLength(0) &&
                            j + dy[k] >= 0 && dy[k] < A.GetLength(1))
                        {
                            if (A[i, j] <= A[i + dx[k], j + dy[k]])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                    if (isOK)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        /*public static int TBai346(int[,] A) //Bai 346
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    bool isOK = true;
                    //Ktra dong
                    for (int k = 0; k < A.GetLength(1);k++)
                    {
                        if(A[i,j]<A[i,k])
                        {
                            isOK = false;
                            break;
                        }
                    }
                    //ktracot
                    if (isOK)
                    {
                        for (int k = 0; k < A.GetLength(0); k++)
                        {
                            if (A[i, j] < A[k, j])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                    //ktra cheo chinh tren
                    if (isOK)
                    { 
                        for (int k = 1; k <= Math.Min(A.GetLength(0) -1 - i, A.GetLength(1) -1 - j);k++)
                        {
                            if ()
                        }
                    }
                }
                if (isOK)
                {
                    dem++;
                }
            }*/
        

        public static bool KiemTraSuTonTaiSoDuong(int[,] A) //Bai 348
        {
            bool pos = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        pos = true;
                        break;
                    }
                }
            }
            return pos;
        }

        public static bool KiemTraTonTaiSoHoanThien(int[,] A) //bai 349
        {
            bool per = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoHoanThien(A[i, j]) == true)
                    {
                        per = true;
                        break;
                    }
                }
            }
            return per;
        }

        public static bool KiemTraSoLe(int[,] A) //Bai 350
        {
            bool odd = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1)
                    {
                        odd = true;
                        break;
                    }
                }
            }
            return odd;
        }
        public static bool KiemTraToanDuong(int[,] A) //Bai 351
        {
            bool allPos = true;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        allPos = false;
                        break;
                    }
                }
            }
            return allPos;
        }
        public static bool KiemTraTangDanTrongHang(int[,] A, int k) //Bai 352
        {
            bool ascending = true;
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                if (A[k, j] >= A[k, j + 1])
                {
                    ascending = false;
                    break;
                }
            }
           
            
            return ascending;
        }

        public static bool KiemTraGiamDanTrongCot(int[,] A, int k) //Bai 353
        {
            bool descending = true;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] <= A[i + 1, k])
                {
                    descending = false;
                    break;
                }
            }
            return descending;
        }

        public static bool KiemTraMaTranGiamDan(int[,] A) //Bai 354
        {
            bool descending = true;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] <= A[i, j + 1] || A[i, j] <= A[i + 1, j])
                    {
                        descending = false;
                        break;
                    }
                }
            }
            return descending;
        }

        public static void LietKeCacDongToanAm(int[,] A) //Bai 355
                                                         //1. Assign a count for 0.
                                                         //2. Run 2 for loop to access to the 2D array.
                                                         //3. Inside those loop, use an if statement. If the element fits the conditional statement, increase the count by 1.
                                                         //4. Use another if statement to define whether all elements in that row are fits (count = number of column).
                                                         //5. Use a for loop to access that row from the start, print them all.
                                                         //6. After the second for loop of j, reset the count to 0 to use for the next row.
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        count++;
                        if (count == A.GetLength(1))
                        {
                            for (int t = 0; t < A.GetLength(1); t++)
                            {
                                Console.Write($"{A[i, t]}    ");
                            }

                        }
                    }
                }
                count = 0;
                Console.WriteLine();
            }
        }

        public static void LietKeChiSoDongChan(int[,] A) //Bai 356
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        count++;
                        if (count == A.GetLength(1))
                        {
                            for (int t = 0; t < A.GetLength(1); t++)
                            {
                                Console.Write($"[{i},{t}]    ");
                            }

                        }
                    }
                }
                count = 0;
                Console.WriteLine();
            }
        }
        public static void LietKeDongChuaSoNguyenTo(int[,] A) //Bai 357
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                    {
                        count++;
                        if (count == A.GetLength(1))
                        {
                            for (int t = 0; t < A.GetLength(1); t++)
                            {
                                Console.Write($"{A[i, t]}    ");
                            }

                        }
                    }
                }
                count = 0;
                Console.WriteLine();
            }
        }
        public static void LietKeDongCoGiaTriChan(int[,] A) //Bai 358
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        for (int t = 0; t < A.GetLength(1); t++)
                        {
                            Console.Write($"{A[i, t]}    ");
                        }
                    }
                    break;
                }
                Console.WriteLine();
            }
        }
        public static void LietKeDongCoGiaTriAm(int[,] A) //Bai 359
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        for (int t = 0; t < A.GetLength(1); t++)
                        {
                            Console.Write($"{A[i, t]}    ");
                        }
                    }
                    break;
                }
                Console.WriteLine();
            }
        }
        public static void LietKeCotCoSoChinhPhuong(int[,] A) //Bai 360
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoChinhPhuong(A[i, j]) == true)
                    {
                        for (int t = 0; t < A.GetLength(0); t++)
                        {
                            Console.WriteLine($"{A[t, j]}    ");
                        }
                    }
                    break;
                }
                Console.WriteLine();
            }
        }
        public static void LietKeDongCoGiaTriAm0VaDuong(int[,] A) //Bai 361 Not optimized
        {
            int neg = 0;
            int pos = 0;
            int zero = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                        neg++;
                    else if (A[i, j] > 0)
                        pos++;
                    else
                        zero++;

                    if (neg > 0 && pos > 0 && zero > 0)
                    {
                        for (int t = 0; t < A.GetLength(1); t++)
                        {
                            Console.Write($"{A[i, t]}    ");
                        }
                    }
                }
                neg = 0;
                pos = 0;
                zero = 0;
                Console.WriteLine();
            }
        }
        public static void LietKeCacDongGiamDan(int[,] A) //Bai 362
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    if (A[i, j] > A[i, j + 1])
                    {
                        count++;
                        if (count == A.GetLength(1) - 1)
                        {
                            for (int t = 0; t < A.GetLength(1); t++)
                            {
                                Console.Write($"{A[i, t]}    ");
                            }
                        }
                    }
                }
                count = 0;
                Console.WriteLine();
            }
        }
        public static void LietKeCacCotTangDan(int[,] A) //Bai 363
                                                         //1.Similar to the previous one but swap 2 for loops.
        {
            int count = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0) - 1; i++)
                {
                    if (A[i, j] < A[i + 1, j])
                    {
                        count++;
                        if (count == A.GetLength(0) - 1)
                        {
                            for (int t = 0; t < A.GetLength(0); t++)
                            {
                                Console.Write($"{A[t, j]}    ");
                            }
                        }
                    }
                }
                count = 0;
                Console.WriteLine();
            }
        }
        public static bool KiemTraALaMaTranConCuaB(int[,] A, int[,] B) //Bai 364
        {
            bool check = true;

            for (int i = 0; i <= B.GetLength(0) - A.GetLength(0); i++)
            {
                for (int j = 0; j <= B.GetLength(1) - A.GetLength(1); j++)
                {
                    for (int t = 0; t < A.GetLength(0); t++)
                    {
                        for (int z = 0; z < A.GetLength(1); z++)
                        {
                            if (B[i + t, j + z] != A[t, z])
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    if (check)
                        return true;
                }
            }
            return check;
        }

        public static int SoChanDauTien(int[,] A) //Bai 366
        {
            int even = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        even = A[i, j];
                        break;
                    }
                }
            }
            return even;
        }

        public static int GiaTriLonThuHai(int[,] A) //Bai 368
                                                    //1. Set max for A[0,0]
                                                    //2. Find the max value in the 2D array.
                                                    //3. Set the minDifFromMax for absolute value of max subtract A[0,0].
                                                    //4. Find the 2nd max value in the 2D array by go thru the array and see if any value is has the min difference from max (except itself).
                                                    //5. Meanwhile, update the maxDifFromMax and max2 if any.
        {
            int max = A[0, 0];
            int max2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                    }
                }
            }
            int minDifFromMax = Math.Abs(max - A[0, 0]);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (Math.Abs(A[i, j] - max) < minDifFromMax && Math.Abs(A[i, j] - max) != 0)
                    {
                        minDifFromMax = Math.Abs(A[i, j] - max);
                        max2 = A[i, j];
                    }
                }
            }
            return max2;
        }

        public static int SoDuongDauTien(int[,] A) //Bai 369
        {
            int pos = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        pos = A[i, j];
                        break;
                    }
                }
            }
            return pos;
        }

        public static int GiaTriAmLonNhat(int[,] A) //Bai 370
        {
            int minIndex1 = 0;
            int minIndex2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        minIndex1 = i;
                        minIndex2 = j;
                        break;
                    }
                }
            }
            int maxNeg = A[minIndex1, minIndex2];
            for (int i = minIndex1; i < A.GetLength(0); i++)
            {
                for (int j = minIndex2 + 1; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0 && A[i, j] > A[minIndex1, minIndex2])
                    {
                        maxNeg = A[i, j];
                    }
                }
            }
            return maxNeg;
        }
        public static void LietKeDongChuaMax(int[,] A) //Bai 371
        {
            int max = XL_Mang2Chieu.GiaTriLonNhat(A);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == max)
                    {
                        for (int t = 0; t < A.GetLength(1); t++)
                        {
                            Console.Write($"{A[i, t]}   ");
                        }
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static int GiaTriLonNhatTrenDong(int[,] A, int k) //Bai 372
        {
            int max = A[k, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[k, j] > max)
                {
                    max = A[k, j];
                }
            }
            return max;
        }

        public static int GiaTriLonNhatTrenCot(int[,] A, int k)
        {
            int max = A[0, k];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] > max)
                    max = A[i, k];
            }
            return max;
        }
        public static int GiaTriNhoNhatTrenCot(int[,] A, int k) //Bai 373
        {
            int min = A[0, k];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, k] < min)
                    min = A[i, k];
            }
            return min;
        }
        public static int SoNguyenToDauTien(int[,] A) //Bai 374
        {
            int firstPrime = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                    {
                        firstPrime = A[i, j];
                        break;
                    }
                }
            }
            return firstPrime;
        }

        public static int SoChanLonNhat(int[,] A) //Bai 375
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int maxEven = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0 && A[i, j] > maxEven)
                        maxEven = A[i, j];
                }
            }
            return maxEven;
        }
        public static int SoChanNhoNhat(int[,] A)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int minEven = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0 && A[i, j] < minEven)
                        minEven = A[i, j];
                }
            }
            return minEven;
        }
        public static int SoDuongNhoNhat(int[,] A) //Bai 376
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int minPos = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0 && A[i, j] < minPos)
                        minPos = A[i, j];
                }
            }
            return minPos;
        }
        public static int SoNguyenToLonNhat(int[,] A) //Bai 377
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int maxPrime = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true && A[i, j] > maxPrime)
                        maxPrime = A[i, j];
                }
            }
            return maxPrime;
        }
        public static int ChuSoXuatHienNhieuNhat(int[,] A) //Bai 378
        {
            int[] B = new int[10];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int temp = Math.Abs(A[i, j]);
                    if (temp == 0)
                        B[0]++;
                    while (temp > 0)
                    {
                        int d = temp % 10;
                        B[d]++;
                        temp = temp / 10;
                    }
                }
            }
            int max = XL_Mang.GiaTriLonNhat(B);
            return max;
        }

        public static int DemSoLuongMin(int[,] A) //Bai 379
        {
            int count = 0;
            int min = XL_Mang2Chieu.GiaTriNhoNhat(A);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == min)
                        count++;
                }
            }
            return count;
        }

        public static int DemSoLuongSoChanNhoNhat(int[,] A) //Bai 380
        {
            int count = 0;
            int minEven = XL_Mang2Chieu.SoChanNhoNhat(A);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == minEven)
                        count++;
                }
            }
            return count;
        }

        public static int GiaTriXuatHienNhieuNhat(int[,] A) //Bai 381 Not done
        {
            int max = 0;
            return max;
        }
        public static int SoChinhPhuongLonNhat(int[,] A) //Bai 382
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoChinhPhuong(A[i, j]) == true)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int max = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoChinhPhuong(A[i, j]) == true && A[i, j] > max)
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static int SoHoanThienNhoNhat(int[,] A) //Bai 383
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoHoanThien(A[i, j]) == true)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }
            int minPerfect = A[index1, index2];
            for (int i = index1; i < A.GetLength(0); i++)
            {
                for (int j = index2 + 1; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoHoanThien(A[i, j]) == true && A[i, j] < minPerfect)
                    {
                        minPerfect = A[i, j];
                    }
                }
            }
            return minPerfect;
        }
        public static void CacChuSoXuatHienNhieuNhat(int[,] A) //Bai 384
        {
            int[] B = new int[10];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int temp = Math.Abs(A[i, j]);
                    if (temp == 0)
                        B[0]++;
                    while (temp > 0)
                    {
                        int d = temp % 10;
                        B[d]++;
                        temp = temp / 10;
                    }
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > 1)
                {
                    Console.Write($"{B[i]}     ");
                }
            }
        }

        public static void LietKeDongCoTongLonNhat(int[,] A) //Bai 385
        {
            int maxTotal = XL_Mang2Chieu.TinhTongDong(A, 0);
            int maxRow = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (XL_Mang2Chieu.TinhTongDong(A, i) > maxTotal)
                    maxRow = i;
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[maxRow, j]}    ");
            }
        }

        public static void LietKeCotCoTongNhoNhat(int[,] A) //Bai 386
        {
            int minTotal = XL_Mang2Chieu.TinhTongCot(A, 0);
            int minColumn = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (XL_Mang2Chieu.TinhTongCot(A, j) < minTotal)
                {
                    minColumn = j;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.Write($"{A[i, minColumn]}   ");
            }
        }

        public static void LietKeDongCoNhieuSoChanNhat(int[,] A) // Bai 387
                                                                 // 1. Assign the row whose the most even numbers to the first row (A[0,j]) by counting its number of even.
                                                                 // 2. Run two for loop to get access to another rows. For every row, assign a temp count.
                                                                 // 3. For every column, if an element is an even number, increase temp count by 1. At the same time, if the temp count is greater than the max count, assign the temp count to the max count and row index to the max row index.
                                                                 // 4. Run a loop to get access of the row we got, print every elements.

        {
            int maxRow = 0;
            int maxCount = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[0, j] % 2 == 0)
                    maxCount++;
            }

            for (int i = 1; i < A.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                        temp++;
                    if (temp > maxCount)
                    {
                        maxCount = temp;
                        maxRow = i;
                    }
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[maxRow, j]}     ");
            }
        }

        public static void LietKeDongCoNhieuSoNguyenToNhat(int[,] A) //Bai 388
        {
            int maxRow = 0;
            int maxCount = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (XL_NguyenTo.KiemTraNguyenTo(A[0, j]) == true)
                    maxCount++;
            }

            for (int i = 1; i < A.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                        temp++;
                    if (temp > maxCount)
                    {
                        maxCount = temp;
                        maxRow = i;
                    }
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[maxRow, j]}     ");
            }
        }
        public static void LietKeDongCoNhieuSoHoanThienNhat(int[,] A) //Bai 389
        {
            int maxRow = 0;
            int maxCount = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (XL_NguyenTo.KiemTraSoHoanThien(A[0, j]) == true)
                    maxCount++;
            }

            for (int i = 1; i < A.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoHoanThien(A[i, j]) == true)
                        temp++;
                    if (temp > maxCount)
                    {
                        maxCount = temp;
                        maxRow = i;
                    }
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[maxRow, j]}     ");
            }
        }
        public static void LietKeCotCoNhieuChuSoNhat(int[,] A) //Bai 390
        {
            int maxIndex = 0;
            int maxCount = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int temp = A[i, 0];
                while (temp > 0)
                {
                    maxCount++;
                    temp = temp / 10;
                }
            }
            for (int j = 1; j < A.GetLength(1); j++)
            {
                int tempCount = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    int temp = A[i, j];
                    while (temp > 0)
                    {
                        tempCount++;
                        temp = temp / 10;
                    }
                }
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    maxIndex = j;
                }
            }

            Console.WriteLine(maxCount);

            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.Write($"{A[i, maxIndex]}    ");
            }
        }

        public static void HoanVi2Dong(int[,] A, int k, int l) //Bai 392
        {
            int[] B = new int[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[j] = A[k, j];
                A[k, j] = A[l, j];
                A[l, j] = B[j];
            }
            XL_Mang2Chieu.XuatMaTran(A);
        }
        public static void HoanVi2Cot(int[,] A, int k, int l) //Bai 393
        {
            int[] B = new int[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                B[i] = A[i, k];
                A[i, k] = A[i, l];
                A[i, l] = B[i];
            }
            XL_Mang2Chieu.XuatMaTran(A);
        }

        public static void DichXuongXoayVongCacHang(int[,] A) //Bai 394
                                                              //1. Assign a blank 1D array as a buffer.
                                                              //2. Run two for loops to get access to the main array bottom up.
                                                              //3. Swap two rows and the blank array at once until the bottom row is moved up to 1st row position. All other rows lower down by 1 row.
        {
            int[] B = new int[A.GetLength(1)];
            for (int i = A.GetLength(0) - 1; i < A.GetLength(0) && i > 0; i--)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[j] = A[i, j];
                    A[i, j] = A[i - 1, j];
                    A[i - 1, j] = B[j];
                }
            }
            Console.WriteLine(); //Just a line break to distinguish
            XL_Mang2Chieu.XuatMaTran(A);
        }
        public static void DichLenXoayVongCacHang(int[,] A) //Bai 395
        {
            int[] B = new int[A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[j] = A[i, j];
                    A[i, j] = A[i + 1, j];
                    A[i + 1, j] = B[j];
                }
            }
            Console.WriteLine();
            XL_Mang2Chieu.XuatMaTran(A);
        }
        public static void DichTraiXoayVongCacCot(int[,] A) //Bai 396
        {
            int[] B = new int[A.GetLength(0)];
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    B[i] = A[i, j];
                    A[i, j] = A[i, j + 1];
                    A[i, j + 1] = B[i];
                }
            }
            Console.WriteLine();
            XL_Mang2Chieu.XuatMaTran(A);
        }
        public static void DichPhaiXoayVongCacCot(int[,] A) //Bai 397
        {
            int[] B = new int[A.GetLength(0)];
            for (int j = A.GetLength(1) - 1; j < A.GetLength(1) && j > 0; j--)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    B[i] = A[i, j];
                    A[i, j] = A[i, j - 1];
                    A[i, j - 1] = B[i];
                }
            }
            Console.WriteLine();
            XuatMaTran(A);
        }
        public static void DichPhaiXoayVongTheoChieuKimDongHoGiaTriBien(int[,] A, int k) //Bai 398
        {
            int temp;
            for (int j = 0; j < A.GetLength(1) - k; j++)
            {
                temp = A[0, j + k];
                A[0, j + k] = A[0, j];

            }

        }

        public static int[] ChuyenMaTranSangMang(int[,] A)
        {
            //B[write++]
            //
            //
            //
            //
            int[] B = new int[A.Length];

            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[write++] = A[i, j];
                }
            }
            return B;
        }

        public static void Xoa1DongTrongMaTran(int[,] A, int k) //Bai 400
        {
            //1. Create a new 2D array with 1 line lower that the main array.
            //2. If the removed row is the first one, get access to the elements of main array excluding the first row. Then assign them to new array.
            //3. If the removed row is the last one, get access to the elements of main array excluding the last row. Then assign them to new array.
            //4. If the removed row is the one in middle row, get access to the elements of main array excluding the given row. Then assign them to new array.

            Console.WriteLine();
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];

            if (k == 0)
            {
                for (int i = 1; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i - 1, j] = A[i, j];
                    }
                }
            }
            else if (k == A.GetLength(0) - 1)
            {
                for (int i = 0; i < A.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
                for (int i = k + 1; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i - 1, j] = A[i, j];
                    }
                }
            }
            XuatMaTran(B);
        }
        public static void Xoa1CotTrongMaTran(int[,] A, int k) //Bai 401
        {
            Console.WriteLine();
            int[,] B = new int[A.GetLength(0), A.GetLength(1) - 1];
            if (k == 0)
            {
                for (int j = 1; j < A.GetLength(1); j++)
                {
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        B[i, j - 1] = A[i, j];
                    }
                }
            }
            else if (k == A.GetLength(1) - 1)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
            }
            else
            {
                for (int j = 0; j < k; j++)
                {
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
                for (int j = k + 1; j < A.GetLength(1); j++)
                {
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        B[i, j - 1] = A[i, j];
                    }
                }
            }
            XuatMaTran(B);
        }
        public static void XoayMaTran1Goc90(int[,] A) //Bai 402
        //1. First rotation: we rotate about the Secondary Diagonal
        //2. Second rotation: we rotate about the Middle Row (Mirror vertically)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0) - i; j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[A.GetLength(0) - 1 - j, A.GetLength(0) - 1 - i];
                    A[A.GetLength(0) - 1 - j, A.GetLength(0) - 1 - i] = temp;
                }
            }
            for (int i = 0; i < A.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[A.GetLength(0) - 1 - i, j];
                    A[A.GetLength(0) - 1 - i, j] = temp;
                }
            }

            XuatMaTran(A);
        }
        public static void XoayMaTran1Goc180(int[,] A) //Bai 403
        {
            for (int i = 0; i < A.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[A.GetLength(0) - 1 - i, A.GetLength(1) - 1 - j];
                    A[A.GetLength(0) - 1 - i, A.GetLength(1) - 1 - j] = temp;
                }
            }
            XuatMaTran(A);
        }
        public static void XoayMaTran1Goc270(int[,] A) //Bai 404
        {
            Console.WriteLine();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0) - i; j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[A.GetLength(0) - 1 - j, A.GetLength(0) - 1 - i];
                    A[A.GetLength(0) - 1 - j, A.GetLength(0) - 1 - i] = temp;
                }
            }
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[i, A.GetLength(1) - 1 - j];
                    A[i, A.GetLength(1) - 1 - j] = temp;
                }
            }
            XuatMaTran(A);
        }
        public static void ChieuGuongMaTranTheoTrucDoc(int[,] A) //Bai 405
        {
            for (int i = 0; i < A.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[A.GetLength(0) - 1 - i, j];
                    A[A.GetLength(0) - 1 - i, j] = temp;
                }
            }
            XuatMaTran(A);
        }
        public static void ChieuGuongMaTranTheoTrucNgang(int[,] A) //Bai 406
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[i, A.GetLength(1) - 1 - j];
                    A[i, A.GetLength(1) - 1 - j] = temp;
                }
            }
            XuatMaTran(A);
        }
        public static void SapXepPhanTuTren1DongTangDan(int[,] A, int k) //Bai 407
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                for (int z = j + 1; z < A.GetLength(1); z++)
                {
                    if (A[k, j] > A[k, z])
                    {
                        int temp = A[k, j];
                        A[k, j] = A[k, z];
                        A[k, z] = temp;
                    }
                }
            }
            XuatMaTran(A);
        }
        public static void SapXepPhanTuTren1DongGiamDan(int[,] A, int k) //Bai 408
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                for (int z = j + 1; z < A.GetLength(1); z++)
                {
                    if (A[k, j] < A[k, z])
                    {
                        int temp = A[k, j];
                        A[k, j] = A[k, z];
                        A[k, z] = temp;
                    }
                }
            }
            XuatMaTran(A);
        }
        public static void SapXepPhanTuTren1CotTangDan(int[,] A, int k) //Bai 409
        {
            for (int i = 0; i < A.GetLength(0) - 1; i++)
            {
                for (int z = i + 1; z < A.GetLength(0); z++)
                {
                    if (A[i, k] > A[z, k])
                    {
                        int temp = A[i, k];
                        A[i, k] = A[z, k];
                        A[z, k] = temp;
                    }
                }
            }
        }
        public static void SapXepPhanTuTren1CotGiamDan(int[,] A, int k) //Bai 410
        {
            for (int i = 0; i < A.GetLength(0) - 1; i++)
            {
                for (int z = i + 1; z < A.GetLength(0); z++)
                {
                    if (A[i, k] < A[z, k])
                    {
                        int temp = A[i, k];
                        A[i, k] = A[z, k];
                        A[z, k] = temp;
                    }
                }
            }
        }
        public static void XuatGiaTriChanGiamDan(int[,] A) //Bai 411
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoChan(A[i, j]) == true)
                        count++;
                }
            }

            int[] B = new int[count];
            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraSoChan(A[i, j]) == true)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangGiamDan(B);
            XL_Mang.XuatMang(B);
        }
        public static void XuatSoNguyenToTangDan(int[,] A) //Bai 412
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                        count++;
                }
            }

            int[] B = new int[count];
            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_NguyenTo.KiemTraNguyenTo(A[i, j]) == true)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangTangDan(B);
            XL_Mang.XuatMang(B);
        }
        public static void SapXepDongChiSoChanTangDanChiSoLeGiamDan(int[,] A) //Bai 413
        {
            Console.WriteLine();
            for (int i = 2; i < A.GetLength(0); i += 2)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int z = j + 1; z < A.GetLength(1); z++)
                    {
                        if (A[i, j] > A[i, z])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, z];
                            A[i, z] = temp;
                        }
                    }
                }
            }
            for (int i = 1; i < A.GetLength(0); i += 2)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int z = j + 1; z < A.GetLength(1); z++)
                    {
                        if (A[i, j] < A[i, z])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, z];
                            A[i, z] = temp;
                        }
                    }
                }
            }
            XuatMaTran(A);
        }
        public static void SapXepCotChiSoChanGiamDanChiSoLeTangDan(int[,] A)// Bai 414
        {
            Console.WriteLine();
            for (int j = 2; j < A.GetLength(1); j += 2)
            {
                SapXepPhanTuTren1CotGiamDan(A, j);
            }
            for (int j = 1; j < A.GetLength(0); j += 2)
            {
                SapXepPhanTuTren1CotTangDan(A, j);
            }
            XuatMaTran(A);
        }
        public static int[,] ChuyenMangSangMaTran(int[] A, int height, int width)
        {
            // 2Darr[i, j] = 1Darr[i * width + j]
            //
            //
            //
            //
            int[,] B = new int[height, width];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = A[i * B.GetLength(1) + j];
                }
            }
            return B;
        }
        public static void SapXepPhanTuTangDanTheoHangVaCotA(int[,] A) //Bai 415a
        {
            int[] B = ChuyenMaTranSangMang(A);
            XL_Mang.SapXepMangTangDan(B);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = B[i * A.GetLength(1) + j];
                }
            }
            XuatMaTran(A);
        }
        public static void SapXepPhanTuTangDanTheoHangVaCotB(int[,] A) //Bai 415b
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int z = j + 1; z < A.GetLength(1); z++)
                    {
                        if (A[i, j] > A[i, z])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, z];
                            A[i, z] = temp;
                        }
                    }
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0) - 1; i++)
                {
                    for (int z = i + 1; z < A.GetLength(0); z++)
                    {
                        if (A[i, j] > A[z, j])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[z, j];
                            A[z, j] = temp;
                        }

                    }
                }
            }
        }
        public static void SapXepPtuDuongTangDanTheoCotVaDongA(int[,] A) //Bai 416a
        {
            int evenCount = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        evenCount++;
                }
            }

            int[] B = new int[evenCount];

            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        B[write++] = A[i, j];
                }
            }

            write = 0;

            XL_Mang.SapXepMangTangDan(B);

            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] <= 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }
        }
        public static void SapXepPtuDuongTangDanTheoCotVaDongB(int[,] A) //Bai 416b
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int z = j + 1; z < A.GetLength(1); z++)
                    {
                        if (A[i, j] > 0 && A[i, z] > 0 && A[i, j] > A[i, z])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, z];
                            A[i, z] = temp;
                        }
                    }
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0) - 1; i++)
                {
                    for (int z = i + 1; z < A.GetLength(0); z++)
                    {
                        if (A[i, j] > 0 && A[z, j] > 0 && A[i, j] > A[z, j])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[z, j];
                            A[z, j] = temp;
                        }

                    }
                }
            }
        }
        public static int[,] SapXepPTuChanGiamDanTheoDongVaCotA(int[,] A) //Bai 417a
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            int[] B = new int[count];
            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangGiamDan(B);
            write = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] % 2 == 1 || A[i, j] == 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }
            return A;
        }

        public static void SapXepPTuChanGiamDanTheoDongVaCotB(int[,] A) //Bai 417b
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0) - 1; i++)
                {
                    for (int z = i + 1; z < A.GetLength(0); z++)
                    {
                        if (A[i, j] % 2 == 0 && A[z, j] % 2 == 0 && A[i, j] < A[z, j])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[z, j];
                            A[z, j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    for (int z = j + 1; z < A.GetLength(1); z++)
                    {
                        if (A[i, j] % 2 == 0 && A[i, z] % 2 == 0 && A[i, j] < A[i, z])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, z];
                            A[i, z] = temp;
                        }
                    }
                }
            }
        }
        public static void SapXepAmTangDanDuongGiamDan0GiuNguyen(int[,] A) //Bai 418
        {
            int negCount = 0;
            int posCount = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                        negCount++;
                    else if (A[i, j] > 0)
                        posCount++;
                }
            }
            int[] B = new int[negCount];
            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangTangDan(B);
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] >= 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }
            B = new int[posCount];
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangGiamDan(B);
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] <= 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }
        }
        public static void SapXepChanTangLeGiam(int[,] A) //Bai 419
        {
            int oddCount = 0;
            int evenCount = 0;

            //for odd number
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1 && A[i, j] != 0)
                        oddCount++;
                    else if (A[i, j] % 2 == 0 && A[i, j] != 0)
                        evenCount++;
                }
            }
            int[] B = new int[oddCount];
            int write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1 && A[i, j] != 0)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangGiamDan(B);
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0 || A[i, j] == 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }

            //for even numbers
            B = new int[evenCount];
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0 && A[i, j] != 0)
                        B[write++] = A[i, j];
                }
            }
            XL_Mang.SapXepMangTangDan(B);
            write = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 1 || A[i, j] == 0)
                        continue;
                    else
                        A[i, j] = B[write++];
                }
            }

        }

        public static int[,] TaoMaTranBTuAbsA(int[,] A) //Bai 426
        {
            int[,] B = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                        A[i, j] = Math.Abs(A[i, j]);
                    B[i, j] = A[i, j];
                }
            }
            return B;
        }

        public static int[,] TaoMaTranBTuMaxDongVaCotCuaA(int[,] A) //Bai 427
        {
            int[,] B = new int[2, Math.Max(A.GetLength(0), A.GetLength(1))];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                B[0, i] = GiaTriLonNhatTrenDong(A, i);
            }

            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[1, j] = GiaTriLonNhatTrenCot(A, j);
            }
            return B;
        }

        public static int[,] TaoMaTranBTuPTuDuongXungQuanhA(int[,] A) //Bai 428 Not done
        {
            int posCount = DemSoDuongTrenBien(A);
            
            int[,] B = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if ((i == 0 || j == 0) || (i == A.GetLength(0) - 1 || j == A.GetLength(1) - 1) && A[i, j] > 0)
                    {
                        B[i, j] = A[i, j];
                    }
                }
            }
            return B;
        }
        public static int[,] NhapMaTranVuong(string ghiChu) //Bai 429
        {
            Console.WriteLine(ghiChu);
            int[,] A;

            Console.WriteLine("Nhap so dong: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so cot: ");
            int M = int.Parse(Console.ReadLine());

            A = new int[N, M];

            if (N == M)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.WriteLine($"Nhap A[{i}, {j}]");
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("Nhap so dong bang so cot!");
                System.Environment.Exit(0);
            }
            return A;
        }
        public static void XuatMaTranVuong(int[,] A) //Bai 431
        {
            if (A.GetLength(0) == A.GetLength(1))
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        Console.WriteLine($"Nhap A[{i}, {j}]");
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("Ma tran khong vuong!");
                System.Environment.Exit(0);
            }
        }
        public static bool KiemTraMaTranVuong(int[,] A)
        {
            if(A.GetLength(0) == A.GetLength(1))
            {
                return true;
            }
            return false;
        }
        public static int GiaTriLonNhatMaTranVuong(int[,] A) //Bai 433
        {            
            bool check = KiemTraMaTranVuong(A);
            int max = -1;
            if (check == true)
            {
                max = GiaTriLonNhat(A);
            }           
            return max;
        }
    }
}
