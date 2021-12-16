using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public struct Date
    {
        public int DD;
        public int MM;
        public int YYYY;
    }
    public class XL_Ngay
    {
        public static Date NhapNgay(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Date ngay;
            ngay.DD = XL_NguyenTo.NhapSoNguyen("Nhap ngay: ");
            ngay.MM = XL_NguyenTo.NhapSoNguyen("Nhap thang: ");
            ngay.YYYY = XL_NguyenTo.NhapSoNguyen("Nhap nam: ");
            bool check = true;
            while (check)
            {
                if ((ngay.MM == 1 || ngay.MM == 3 || ngay.MM == 5 || ngay.MM == 7 || ngay.MM == 8 || ngay.MM == 10 || ngay.MM == 12) && ngay.DD != 31)
                {
                    Console.WriteLine("Vui long nhap dung so ngay!");
                    check = false;
                    break;
                }
                if ((ngay.MM == 4 || ngay.MM == 6 || ngay.MM == 9 || ngay.MM == 11) && ngay.DD != 30)
                {
                    Console.WriteLine("Vui long nhap dung so ngay!");
                    check = false;
                    break;
                }
                if (ngay.YYYY % 100 == 0 && ngay.MM == 2 && ngay.DD == 29)
                {
                    Console.WriteLine("Vui long nhap dung so ngay!");
                    check = false;
                    break;
                }
                if (ngay.YYYY % 4 == 0 || ngay.YYYY % 400 == 0)
                {
                    if (ngay.MM == 2 && ngay.DD != 29)
                    {
                        Console.WriteLine("Vui long nhap dung so ngay!");
                        check = false;
                        break;
                    }
                }                
            }
            return ngay;
        }
        public static void XuatNgay(Date ngay)
        {
            Console.WriteLine($"{ngay.DD}/{ngay.MM}/{ngay.YYYY}");
        }
    }
    

}
