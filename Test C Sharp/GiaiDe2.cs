using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct LOPHOC
    {
        public string tenLop;
        public HOCSINH[] danhSachHS; 
    }
    public struct HOCSINH
    {
        public string maHS;
        public int diemToan;
        public int diemVan;
        public string ten;
    }
    

    class GiaiDe2
    {
        public static void XuatNgayKeTiep(int ngay, int thang, int nam)
        {
            //Xuat ngay cho thang 4, 6, 9, 11
            //Neu ngay ngoai range 1 - 30, bao loi
            //Neu ngay 30, xuat ngay 1 thang sau
            //Con lai xuat ngay tiep theo trong thang
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay > 30 || ngay < 1)
                {
                    Console.WriteLine("Please input valid day");
                }
                else if (ngay == 30)
                {
                    Console.WriteLine($"The next day is {1}/{thang + 1}/{nam}");
                }
                else
                {
                    Console.WriteLine($"The next day is {ngay + 1}/{thang}/{nam}");
                }
            }

            //Xuat ngay cho thang 1, 3, 5, 7, 8, 10,12
            //1. Neu ngay ngoai range, bao loi
            //2. Neu con lai neu: a) ngay cuoi nam, xuat ngay dau nam tiep theo; b) Ngay 31 cuoi thang nhung k phai cuoi nam, xuat ngay dau thang tiep theo; c) Con lai xuat ngay tiep theo
         
            else if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                if (ngay < 1 || ngay > 31)
                {
                    Console.WriteLine("Please input valid day");
                }
                else
                {
                    if (thang == 12 && ngay == 31)
                    {
                        Console.WriteLine($"The next day is {1}/{1}/{nam + 1}");
                    }
                    else if (thang != 12 && ngay == 31)
                    {
                        Console.WriteLine($"The next day is {1}/{thang + 1}/{nam}");
                    }
                    else 
                    {
                        Console.WriteLine($"The next day is {ngay + 1}/{thang}/{nam}");
                    }
                }
            }

            //Xuat ngay cho thang 2
            //1. Neu ngay ngoai range 1 - 29, bao loi
            //2. Con lai neu: a) Năm nhuận (năm chia hết cho 4 và không chia hết cho 100 HOẶC năm chia hết cho 400), nếu ngày bé hơn 28 thì xuất ngày 29/còn lại xuất đầu tháng sau
            //b) Không phải năm nhuận, ngày là 28 thì xuất đầu tháng sau, nhỏ hơn thì xuất ngày tiếp theo
            else if (thang == 2)
            {
                if (ngay > 29 || ngay < 1)
                {
                    Console.WriteLine("Please input valid day");
                }
                else
                {
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    {
                        if (ngay <= 28)
                        {
                            Console.WriteLine($"The next day is {ngay + 1}/{thang}/{nam}");
                        }
                        else
                        {
                            Console.WriteLine($"The next day is {1}/{thang + 1}/{nam}");
                        }                        
                    }
                    else
                    {
                        if (ngay < 28)
                        {
                            Console.WriteLine($"The next day is {ngay + 1}/{thang}/{nam}");
                        }
                        else if (ngay == 28)
                        {
                            Console.WriteLine($"The next day is {1}/{thang + 1}/{nam}");
                        }
                        else
                        {
                            Console.WriteLine("Please input a valid day");
                        }
                    }
                }
            }

            //Nhập sai tháng, báo lỗi
            else
            {
                Console.WriteLine("Please input a valid month");
            }
        }

        public static int[] NhapMang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong mang:");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            
            for (int i = 0; i < arr.Length; i ++)
            {
                Console.WriteLine($"Array[{i}]:");
                int input = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        public static void XuatMang(int[] arr)
        {
            for (int i =0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        
        public static bool KiemTraSoNguyenTo(int N)
        {
            if (N <= 1)
            {
                return false;
            }
            
                for (int i = 2; i <= N/2; i++)
                {
                    if (N % i == 0)
                    {
                        return false;
                    }                    
                }
            
            return true;
        }
        public static double TinhTBCNguyenTo(int[] A)
        {
            int total = 0;
            int count = 0;
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i]) == true)
                {
                    index = i;
                    break;
                }               
            }
            for (int i = index; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i]) == true)
                {
                    total += A[i];
                    count++;
                }
            }
            return total / count;
            
        }

        public static LOPHOC NhapThongTinLopHoc(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            LOPHOC lopHoc = new LOPHOC();

            Console.WriteLine("Nhap ten lop:");
            lopHoc.tenLop = Console.ReadLine();


            Console.WriteLine("Nhap so luong hoc sinh:");
            int soLuongHS = int.Parse(Console.ReadLine());
            lopHoc.danhSachHS = new HOCSINH[soLuongHS];

            for (int i = 0; i < lopHoc.danhSachHS.Length; i++)
            {
                Console.WriteLine($"Nhap thong tin hoc sinh {i+1}:");

                Console.WriteLine("Nhap ma HS:");
                lopHoc.danhSachHS[i].maHS = Console.ReadLine();

                Console.WriteLine("Nhap ten HS:");
                lopHoc.danhSachHS[i].ten = Console.ReadLine();

                Console.WriteLine("Nhap diem Toan:");
                lopHoc.danhSachHS[i].diemToan = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap diem Van:");
                lopHoc.danhSachHS[i].diemVan = int.Parse(Console.ReadLine());
            }

            return lopHoc;
        }

        public static void XuatThongTinHocSinh(HOCSINH A)
        {
            Console.WriteLine("Hoc sinh Gioi nhat lop:");
            Console.WriteLine($"Ma hoc sinh: {A.maHS}");
            Console.WriteLine($"Ten hoc sinh {A.ten}");
            Console.WriteLine($"Diem toan: {A.diemToan}");
            Console.WriteLine($"Diem van: {A.diemVan}");
            Console.WriteLine($"Diem TB: {(A.diemToan * A.diemVan) / 2}");
        }

        public static HOCSINH TimHocSinhGioiNhat(LOPHOC lop)
        {
            double diemTBMon = 0;
            int index = new int();
            for (int i = 0; i < lop.danhSachHS.Length; i++)
            {
                if ((lop.danhSachHS[i].diemToan + lop.danhSachHS[i].diemVan)/2 > diemTBMon)
                {
                    index = i;
                    diemTBMon = (lop.danhSachHS[i].diemToan + lop.danhSachHS[i].diemVan) / 2;
                }
            }
            return lop.danhSachHS[index];

        }

    }
}
