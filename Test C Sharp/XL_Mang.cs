using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
	class XL_Mang
	{
		public static int[] NhapMang(string ghiChu)
		{
			Console.WriteLine(ghiChu);

			//Nhap mang
			int[] A;
			Console.WriteLine("Nhap so luong mang: ");
			int N = int.Parse(Console.ReadLine());
			A = new int[N];
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine($"Nhap A[{i}]:");
				A[i] = int.Parse(Console.ReadLine());
			}

			return A;
		}
		public static PhanSo[] NhapMangPhanSo(string ghiChu)
        {
			Console.WriteLine(ghiChu);
		
			Console.WriteLine("Nhap so luong mang: ");
			int N = int.Parse(Console.ReadLine());
			PhanSo[] A = new PhanSo[N];
			for (int i = 0; i < A.Length; i++)
            {
				A[i] = XuLyPhanSo.NhapPhanSo($"Nhap phan tu A[{i}]: ");
            }
			return A;
        }
		public static PhanSo TongMangPhanSo(PhanSo[] A)
		{
			//Tinh tong cac phan tu trong mang
			PhanSo S;
			S.TuSo = 0;
			S.MauSo = 1;
			for (int i = 0; i < A.Length; i++)
			{
				S = XuLyPhanSo.TongHaiPhanSo(S, A[i]);
			}

			return S;
		}

		public static int TongMang(int[] A)
		{
			//Tinh tong cac phan tu trong mang
			int S = 0;
			for (int i = 0; i < A.Length; i++)
			{
				S = S + A[i];
			}

			return S;
		}

		public static void XuatMang(int[] A)
		{
			//Xuat mang
			for (int i = 0; i < A.Length; i++)
			{
				Console.Write($"{A[i]}    ");
			}
			Console.WriteLine();
		}

		public static int GiaTriLonNhat(int[] A)
        {
			int max = A[0];
			for (int i = 1; i < A.Length; i++)
            {
				if (max < A[i])
				{
					max = A[i];
				}
            }
			return max;
		}

		public static int DemSoNguyenTo(int[] A) //Module 125
        {
			int dem = 0;
			for (int i = 1; i < A.Length; i++)
            {
				if (A[i] < 100 && XL_NguyenTo.KiemTraNguyenTo(A[i]) == true)
                {
					dem++;
                }					
            }
			return dem;
        }

		public static int ViTriCoGiaTriNhoNhatMangSoNguyen(int[] A) //Module 123
        {
			int min = A[0];
			for (int i = 1; i < A.Length; i++)
            {
				if (A[i] < min)
					min = A[i];
            }
			return Array.IndexOf(A,min);
        }

		public static bool KtraGiaTriChanNhoHon2004(int[] A) //Module 124
        {
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > 0 && A[i] < 2004)
					return true;
			}
			return false;	
        }

		public static int TongMangCacGiaTriAm(int[] A) //Module 126
		{
			//Bai nay dang gap van de trong data type, not done yet
			int S = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] < 0)
				{
					S = S + A[i];
				}
			}
			return S;
		}

		//Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần
		public static void SapXepMangTangDan(int[] A) //Module 127
        {
			int temp;

			for (int i = 0; i < A.Length - 1; i++)
            {
				for (int j = i + 1; j < A.Length; j++)
				{
					if (A[i] > A[j])
					{
						temp = A[i];
						A[i] = A[j];
						A[j] = temp;
					}
				}
            }
		}
		public static void SapXepMangGiamDan(int[] A) //Module 127b
		{
			int temp;

			for (int i = 0; i < A.Length - 1; i++)
			{
				for (int j = i + 1; j < A.Length; j++)
				{
					if (A[i] < A[j])
					{
						temp = A[i];
						A[i] = A[j];
						A[j] = temp;
					}
				}
			}
		}

		//Viết hàm liệt kê các giá trị chẵn trong mảng 1 chiều các số nguyên

		public static void LietKeSoNguyenChan(int[] A) //132
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] % 2 == 0)
                {
					Console.WriteLine(A[i] + " ");					
                }					
            }				
        }

		//Viết hàm liệt kê các vị trí mà giá trị tại đó là giá trị âm trong mảng 1 chiều các số thực
		public static void LietKeViTriSoAm(float[] A) //133
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] < 0)
                {
					Console.WriteLine(Array.IndexOf(A,A[i]) + " ");
                }					
            }				
        }
		//Viết hàm tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực.Nếu mảng không có giá trị dương thì trả về -1
		public static float TimGiaTriDuongDauTien(float[] A) //135
        {
			float positive = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] > 0)
                {
					positive = A[i];
					break; //neu cho nay khong dung linh canh thi thay bang "return i"
				}
			}
			return positive;
		}
		//Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì trả về -1
		public static int SoChanCuoiCung(int[] A)
        {
			int lastEven = -1;
			for (int i = A.Length - 1; i < A.Length; i--)
            {
				if (A[i] % 2 == 0)
				{
					lastEven = A[i];
					break;
                }
            }
			return lastEven;
        }
		public static float ViTriCoGiaTriNhoNhatMangSoThuc(float[] A) //Module 137
		{
			float min = A[0];
			for (int i = 1; i < A.Length; i++)
			{
				if (A[i] < min)
					min = A[i];
			}
			return Array.IndexOf(A, min);
		}
		public static int GiaTriDuongNhoNhatMangSoThuc(int[] A) //Module 140 
		//Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì sẽ trả về -1
		{
			//gan minIndex cho chi so cua phan tu duong dau tien
			int minIndex = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] > 0)
                {
					minIndex = i;
					break;
                }				
            }
			if (minIndex >= 0) //co phan tu duong
            {
				for (int i = minIndex + 1; i < A.Length; i++)
                {
					if (A[i] > 0 && A[i] < A[minIndex])
                    {
						minIndex = i;
                    }						
                }					
            }
			return minIndex;
		}
		//Tìm số nguyên tố đầu tiên trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về  – 1
		public static int SoNguyenToDauTien(int[] A) //Bai 144
        {
			int firstPrime = -1;
			for (int i = 0; i < A.Length; i++)
			{
				if (XL_NguyenTo.KiemTraNguyenTo(A[i]) == true)
				{
					firstPrime = A[i];
					break;
				}
			}
			return firstPrime;
        }

		public static int TimSoHoanThienDauTien(int[] A) //Bai 145
        {
			int firstPerfectNum = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (XL_NguyenTo.KiemTraSoHoanThien(A[i]) == true)
                {
					firstPerfectNum = A[i];
					break;
                }
			}
			return firstPerfectNum;
        }

		public static int SoNguyenToCuoiCung(int[] A) //Bai 148
        {
			int lastPrimeNum = -1;
			for (int i = A.Length - 1; i < A.Length; i--)
            {
				if (XL_NguyenTo.KiemTraNguyenTo(A[i]) == true)
				{
					lastPrimeNum = A[i];
					break;
				}
            }
			return lastPrimeNum;
        }

		public static int TimSoHoanThienCuoiCung(int[] A) //Bai 149
		{
			int firstPerfectNum = -1;
			for (int i = A.Length - 1; i < A.Length; i--)
			{
				if (XL_NguyenTo.KiemTraSoHoanThien(A[i]) == true)
				{
					firstPerfectNum = A[i];
					break;
				}
			}
			return firstPerfectNum;
		}
		public static int GiaTriAmLonNhat(int[] A) //Bai 150
			/*Algorithm:
				1. Set a variable for -1
				2. Define if there is any negative number in the array, return the index of that number.
				3. If there is a negative number, the minIndex will be greater or equal to 0. Then, we check the elements from that number to the end if they are negative one by one and find the max.
			(save the memory by passing the preceding positive).
				4. Return the index. Back to the main program and write the value based on that index (e.g A[maxIndex]).
			*/
        {
			int maxIndex = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] < 0)
                {
					maxIndex = i;
					break;
                }					
            }
			if (maxIndex >= 0)
            {
				for (int i = maxIndex + 1; i < A.Length -1; i++)
                {
					if (A[i] < 0 && A[i] > A[maxIndex])
                    {
						maxIndex = i;
                    }
                }
            }
			return maxIndex;
        } 
		public static int SoNguyenToLonNhat(int[] A) //Bai 151
        {
			int maxIndex = -1;
			for (int i = 0; i < A.Length; i++)
			{
				if (XL_NguyenTo.KiemTraNguyenTo(A[i]) == true)
				{
					maxIndex = i;
					break;
				}
			}
			if (maxIndex >= 0) //co phan tu duong
			{
				for (int i = maxIndex + 1; i < A.Length; i++)
				{
					if (XL_NguyenTo.KiemTraNguyenTo(A[i]) == true && A[i] > A[maxIndex])
					{
						maxIndex = i;
					}
				}
			}
			return maxIndex;
		}

		public static int SoHoanThienNhoNhat(int[] A) //152
        {
			int minIndex = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if(XL_NguyenTo.KiemTraSoHoanThien(A[i]) == true)
                {
					minIndex = i;
					break;
                }					
            }				
			if (minIndex >= 0)
            {
				for (int i = minIndex + 1; i < A.Length - 1; i++)
                {
					if(XL_NguyenTo.KiemTraSoHoanThien(A[i]) == true && A[i] < A[minIndex])
                    {
						minIndex = i;
                    }						
                }					
            }
			return minIndex;
        }

		public static int GiaTriChanNhoNhat(int[] A) //Bai 153
        {
			int minIndex = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] > 0 && A[i] % 2 == 0)
                {
					minIndex = i;
					break;
                }					
            }
			if (minIndex >= 0)
            {
				for (int i = minIndex + 1; i < A.Length; i++)
                {
					if (A[i] % 2 == 0 & A[i] < A[minIndex])
                    {
						minIndex = i;
                    }						
                }					
            }
			return minIndex;
        }

		public static int GiaTriAmNhoNhat(int[] A) //Bai 154
        {
			int minIndex = -1;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] < 0)
				{
					minIndex = i;
					break;
				}
			}
			if (minIndex >= 0)
			{
				for (int i = minIndex + 1; i < A.Length - 1; i++)
				{
					if (A[i] < 0 && A[i] < A[minIndex])
					{
						minIndex = i;
					}
				}
			}
			return minIndex;
		}
		public static int TimPhanTuXaNhat(int[] A, int x) //155
        {
			int maxIndex = 0;
			for (int i = 1; i < A.Length; i++)
            {
				if (Math.Abs(x - A[i]) > Math.Abs(x - A[maxIndex]))
                {
					maxIndex = i;
                }
            }
			return maxIndex;
        }
		
		public static int TimPhanTuGanNhat(int[] A, int x) //Bai 156
        {
			int minIndex = 0;
			for (int i = 1; i < A.Length; i++)
            {
				if (Math.Abs(x - A[i]) < Math.Abs(x - A[minIndex]))
                {
					minIndex = i;
                }					
            }
			return minIndex;
        }

		/*public static int TimDoanChuaMang(int[] A) //Bai 157
			//Not done yet
        {
			XL_Mang.SapXepMangTangDan(A);
			int min = Math.Floor(A[0]);
			int max = Math.Ceiling(A[A.Length - 1]);
			return min; 
			return max;
        }*/
		
		public static int GiaTriDauTienLonHon2003(int[] A) //Bai 159
        {
			int result = -1;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > 2003)
                {
					result = A[i];
					break;
                }				
            }
			return result;
        }

		public static int GiaTriAmCuoiCungLonHonAm1(int[] A) //Bai 160
        {
			int Index = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] < 0)
                {
					Index = i;
					break;
                }
            }
			for (int i = A.Length - 1; i < A.Length && i >= Index; i--)
            {
				if (A[i] > -1)
                {
					Index = i;
                }
            }
			return Index;
        }
		public static int GiaTriDauTienTrongDoan(int[] A, int x, int y) //Bai 161
		{
			int firstValue = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if(A[i] > x && A[i] < y)
                {
					firstValue = A[i];
					break;
                }
            }
			return firstValue;
        }

		public static int Bai162(int[] A) //Bai162
        {
			int index = -1;
			int temp = 0;
			for (int i = 0; i < A.Length; i++)
            {
				if (i > 0 && i < A.Length)
                {
					temp = i;
					break;
                }					
            }				
			for (int i = temp; i < A.Length - 1; i++)
            {
				if (A[i] == A[i - 1] * A[i + 1])
                {
					index = i;
					break;
                }						
            }
			return index;
        }
		public static int SoChinhPhuongDauTien(int[] A) //Bai 163
        {
			int sqNum = -1;
			int temp = 0;
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] > 0)
                {
					temp = i;
					break;
                }					
            }				
			if (temp >= 0)
            {
				for (int i = temp; i < A.Length; i++)
                {
					double result = Math.Sqrt(A[i]);
					if (result % 1 == 0) //To check if this is an integer
                    {
						sqNum = A[i];
						break;
                    }
                }
            }
			return sqNum;
        }

		public static int TimSoGanhDauTien(int[] A) //164
        {
			for(int i = 0; i <A.Length; i++)
            {
				if(XL_NguyenTo.KiemTraTinhDoiXung(A[i]))
                {
					return i;
                }
            }
			return -1;
        }
		public static int SoDauTienCoDonViDauLe(int[] A) //165
        {
			int oddIndex = -1;
			for (int i = 0; i < A.Length; i++)
            {
				if (XL_NguyenTo.TimSoDao(A[i]) % 2 == 1)
                {
					oddIndex = i;
					break;
                }
            }
			return oddIndex;
		}
		
		public static int SoDauTienCoDang2muK(int[] A) //166
        {
			int result = 0;
			for (int i = 0; i < A.Length; i++)
            {
				double temp = Math.Log2(A[i]);
				if (temp % 1 == 0)
                {
					result = A[i];
					break;
                }
            }
			return result;
        }

		public static int SoLonNhatToanChuSoLe(int[] A) //167
        {
			int maxOdd = -1;
			for (int i = 0; i <A.Length; i++)
            {
				if(XL_NguyenTo.KiemTraSoToanChuSoLe(A[i]) == true)
					maxOdd = i;
			}
			int max = A[maxOdd];
			if (maxOdd >= 0)
            {
				for (int i = maxOdd + 1; i < A.Length; i++)
                {
					if (XL_NguyenTo.KiemTraSoToanChuSoLe(A[i]) == true && A[i] > A[maxOdd])
						max = A[i];
                }
            }
			return max;
        }

		public static int SoLonNhatCoDang5muK(int[] A) //Bai 168
        {
			int maxIndex = 0;
			for (int i = 0; i < A.Length; i++)
            {
				double temp = Math.Log(A[i], 5);
				if (temp % 1 == 0)
                {
					maxIndex = i;
					break;
                }
            }			
			if (maxIndex >= 0)
            {
				for (int i = maxIndex + 1; i < A.Length; i++)
                {
					if (A[i] > A[maxIndex])
                    {
						maxIndex = i;
                    }
                }
            }
			return maxIndex;
        }
		public static int SoChanNhoNhatLonHonMoiGiaTriTrongMang(int[] A) //Bai 169
        {
			int minEven = 0;
			int max = A[0];
			for (int i = 1; i < A.Length; i++)
            {
				if (max < A[i])
                {
					max = A[i];
                }
            }
			if (max % 2 == 0)
			{
				minEven = max + 2;
			}
			else minEven = max + 1;
			return minEven;
        }
		public static int SoNguyenToNhoNhatLonHonMoiGiaTriTrongMang(int[] A) //Bai 170
        /* Algorithm:
			1.Find the max in the array.
			2.Assign minPrime we're looking for to max + 1
			3.Use loop while to find the least minPrime
			4.Increase minPrime by 1 until minPrime is a prime number. */         
		{
			int max = A[0];
			int minPrime = 0;
			for (int i = 1; i < A.Length; i++)
            {
				if (A[i] > max)
                {
					max = A[i];
                }
            }
			minPrime = max + 1;
			while (minPrime > max)
            {
				if (XL_NguyenTo.KiemTraNguyenTo(minPrime) == true)
                {
					break;
                }
				minPrime++;
            }
			return minPrime;
        }

		
		public static int UocChungLonNhatCuaCacPhanTu(int[] A) //Bai 171
        {
			//Algorithm
			//1.Find the GDC of 2 nums
			//2.Find the GDC of the array BY PAIR

			int result = A[0];
			for (int i = 1; i < A.Length; i++)
            {
				result = XL_NguyenTo.UocChungLonNhat(A[i], result);
				if (result == 1)
                {
					return 1;
                }
            }
			return result;
		}

		public static int BoiChungNhoNhatCuaCacPhanTu (int[] A) //Bai 172
        {
			int result = A[0];
			for (int i = 1; i < A.Length; i++)
            {
				result = result * A[i] / XL_NguyenTo.UocChungLonNhat(A[i], result);
            }
			return result;
        }
		public static int TimChuSoXuatHienItNhat(int[] A) //173
        {
			int[] count = new int[10];
			for (int i = 0; i < A.Length; i++)
            {
				int T = Math.Abs(A[i]);
				if (T == 0)
					count[0]++;
				while(T > 0)
                {
					int d = T % 10;
					count[d]++;
					T = T / 10;
                }
            }
			int result = GiaTriDuongNhoNhatMangSoThuc(count);
			return result;			
		}
		public static void XuatTUngDoiMot(int[] A) //Bai174
        {
			for (int i = 0; i < A.Length - 1; i++)
            {
				for (int j = i + 1; j< A.Length; j++)
                {
					if (A[i] < A[j])
						Console.WriteLine($"{A[i]}  -  {A[j]}");
					else
						Console.WriteLine($"{A[j]}  -  {A[i]}");
				}
            }
        }

		public static void HaiGiaTriGanNhauNhat(int[] A) //Bai 175
        {

			SapXepMangTangDan(A);
			int index1 = 0;
			int index2 = 0;
			for (int i = 1; i < A.Length -1; i++)
            {
				for (int j = i + 1; j < A.Length; j++)
                {
					int maxDif = Math.Abs(A[0] - A[1]);
					if (Math.Abs(A[i] - A[j]) < maxDif)
                    {						
						index1 = i;
						index2 = j;
                    }
                }
            }
			Console.WriteLine($"{A[index1]}  -  {A[index2]}");
		}

		public static void LietKeSoAm(int[] A) //Bai 176
        {
			for (int i = 0; i < A.Length; i ++)
            {
				if (A[i] < 0)
                {
					Console.Write($"{A[i]}    ");
                }					
            }				
        }

		public static void LietKeSoThuocDoanChoTruoc(int[] A, int x, int y) //Bai 177
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (A[i] >= x && A[i] <= y)
                {
					Console.Write($"{A[i]}    ");
                }					
            }				
        }

		public static void LietKeSoChanThuocDoanChoTruoc(int[] A, int x, int y) //Bai 178
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (XL_NguyenTo.KiemTraSoChan(A[i]) ==  true && A[i] >= x && A[i] <= y)
                {
					Console.Write($"{A[i]}    ");
                }					
            }				
        }

		public static void LietKeSoLonHonGiaTriTuyetDoiCuaSoSau(int[] A) //Bai 179
        {
			for (int i = 0; i < A.Length - 1; i++)
            {
				if (A[i] > Math.Abs(A[i + 1]))
                {
					Console.Write($"{A[i]}    ");
                }					
            }				
        }

		public static void LietKeSoNhoHonGiaTriTuyetDoiSauNoVaLonHonGiaTriTuyetDoiTruocNo(int[] A) //Bai180
        {
			for (int i = 1; i < A.Length - 1; i++)
            {
				if(A[i] > Math.Abs(A[i - 1]) && A[i] < Math.Abs(A[i + 1]))
                {
					Console.Write($"{A[i]}     ");
                }					
            }				
        }

		public static void LietKeSoChanCoSoChanNamLienKe(int[] A) //Bai 181
        {			
			if (XL_NguyenTo.KiemTraSoChan(A[1]) == true && XL_NguyenTo.KiemTraSoChan(A[0]) == true)
					Console.Write($"{A[0]}     ");
			if (XL_NguyenTo.KiemTraSoChan(A[A.Length - 2]) == true && XL_NguyenTo.KiemTraSoChan(A[A.Length - 1]) == true)
					Console.Write($"{A[A.Length - 1]}     ");
			for (int i = 1; i < A.Length - 1; i++)
			{
				if (XL_NguyenTo.KiemTraSoChan(A[i]) == true && (XL_NguyenTo.KiemTraSoChan(A[i - 1]) == true || XL_NguyenTo.KiemTraSoChan(A[i + 1]) == true))
					Console.Write($"{A[i]}    ");
			}				
        }

		public static void LietKeGiaTriCoSoLienKeTraiDau(int[] A) //Bai 182
        {
			if (XL_NguyenTo.KiemTraTraiDau(A[0], A[1]) == true)
				Console.Write($"{A[0]      }");
			if (XL_NguyenTo.KiemTraTraiDau(A[A.Length - 1], A[A.Length - 2]) == true)
				Console.Write($"{A[A.Length - 1]}");
			for (int i = 1; i < A.Length - 1; i++)
            {
				if (XL_NguyenTo.KiemTraTraiDau(A[i],A[i - 1]) == true || XL_NguyenTo.KiemTraTraiDau(A[i], A[i + 1]) == true)
					Console.Write($"{A[i]}    ");
			}
        }

		public static void LietKeViTriCacSoNguyenTo(int[] A) //Bai 184
		{
			for (int i = 0; i < A.Length; i++)
			{
				if (XL_NguyenTo.KiemTraNguyenTo(A[i]) == true)
					Console.Write($"{i}");
			}
		}

		public static void LietKeViTriCacSoChinhPhuong(int[] A) //Bai 185
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (XL_NguyenTo.KiemTraSoChinhPhuong(A[i]) == true)
					Console.Write($"{i}    ");
            }
        }
		public static void LietKeViTriBangSoAmDauTien(int[] arr) //Bai 186
        {
			int negIndex = -1;
			for (int i = 0; i < arr.Length; i++)
            {
				if (arr[i] < 0)
				{
					negIndex = i;
					Console.WriteLine($"{negIndex}");
					break;
				}					
            }
			if (negIndex >= 0)
			{
				for (int i = negIndex + 1; i < arr.Length; i++)
				{
					if (arr[i] == arr[negIndex])
					{
						Console.Write($"{i}    ");
					}					
				}
			}
			else
				Console.Write("There is no negative number in this array");
		}

		public static void LietKeViTriBangGiaTriDuongNhoNhat(int[] arr) //Bai 187
        {
			int posIndex = -1;
			for (int  i = 0; i < arr.Length; i++)
            {
				if (arr[i] > 0)
                {
					posIndex = i;
					break;
                }
            }
			if (posIndex >= 0)
			{
				for (int i = posIndex; i < arr.Length; i++)
				{
					if (arr[i] < arr[posIndex] && arr[i] > 0)
					{
						posIndex = i;
						Console.WriteLine($"{posIndex}");
					}	
				}
			}
			else
				Console.Write("There is no positive number in this array");
			for (int i = posIndex; i < arr.Length; i++)
            {
				if (arr[i] == arr[posIndex])
					Console.Write($"{i}    ");
            }
        }

		public static void LietKeCacViTriChanLonNhat(int[] arr) //Bai 188
        {
			int maxIndex = -1;
			for (int i = 0; i < arr.Length; i++)
            {
				if (arr[i] > 0)
                {
					maxIndex = i;
					break;
                }
            }
			if (maxIndex >= 0)
            {
				for (int i = maxIndex; i < arr.Length; i++)
                {
					if (arr[i] > arr[maxIndex])
                    {
						maxIndex = i;
						Console.WriteLine($"{maxIndex}");
                    }
                }
            }
			for (int i = maxIndex; i < arr.Length; i++)
            {
				if (arr[i] == arr[maxIndex])
                {
					Console.Write($"{i}   ");
                }
            }
        }

		public static void LietKeSoBatDauBangSoLe(int[] A) //Bai 189
        {
			for (int i = 0; i < A.Length; i++)
            {
				if (XL_NguyenTo.TimSoDao(A[i]) % 2 == 1)
                {
					Console.Write($"{A[i]}      ");
                }
            }
        }

		public static void LietKeGiaTriToanChuSoLe(int[] A) //Bai 190
        {
			for (int i = 0; i < A.Length; i++)
            {
				int temp = A[i];
				int P = 1;
				while (temp > 0)
                {
					int d = temp % 10;
					temp = temp / 10;
					P = P * d;					
				}
				if (P % 2 == 1)
					Console.Write($"\n{A[i]}    ");				
			}
        }

		public static void LietKeCacGiaTriCucDai(int[] A) //Bai 191
        {
			if (A[0] > A[1])
			{
				Console.Write($"{A[0]}    ");
			}
			if (A[A.Length - 1] > A[A.Length - 2])
			{
				Console.Write($"{A[A.Length - 1]}   ");
			}			

			for (int i = 1; i < A.Length - 1; i++)
            {		
				if (A[i] > A[i-1] && A[i] > A[i+1])
					Console.Write($"{A[i]}    ");
			}				
        }

		public static void LietKeCacSoCoSoChanDauTien(int[] A) //Bai 192
        {
			for (int i = 0; i < A.Length; i++)
            {
				if(XL_NguyenTo.TimSoDao(A[i]) % 2 == 0)
                {
					Console.Write($"{A[i]}    ");
				}
            }
        }

		public static void LietKeCacGiaTri3muK(int[] A) //Bai 193
		{
			int temp = 0;
			int index = -1;
			for (int i = 0; i < A.Length; i++)
			{
				if (Math.Log(A[i], 3) % 1 == 0)
				{
					index = i;
				}
			}
			if (index >= 0)
			{
				for (int i = 0; i < A.Length; i++)
				{
					if (Math.Log(A[i], 3) % 1 == 0)
					{
						Console.Write($"{A[i]}    ");
						Console.WriteLine();
					}
				}
			}
			else
				Console.WriteLine(temp);
		}
		public static void LietKeCapGiaTriGanNhauNhat(int[] A) //Bai 194
        {
			int index = 0;
			int min = Math.Abs(A[0] - A[1]);
			if (A.Length < 2)
            {
				Console.WriteLine("Mang can nhieu hon 2 gia tri");
				System.Environment.Exit(0);
            }
						
				for (int i = 1; i < A.Length -1; i++)
                {
					if (Math.Abs(A[i] - A[i+1]) < min)
                    {
						index = i;
						min = Math.Abs(A[i] - A[i + 1]);
                    }
                }
			Console.Write($"Cap gia tri gan nhau nhat: ");
			for (int i = index; i < A.Length - 1; i++)
            {
				if (Math.Abs(A[i] - A[i + 1]) <= min)
                {
					
					Console.Write($"{A[i]} - {A[i + 1]} ");
				}

            }
			
        }


	}
}