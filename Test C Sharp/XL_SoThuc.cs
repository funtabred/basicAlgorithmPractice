using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    public class XL_SoThuc
    {
        public static double NhapSoThuc(string note)
        {
            Console.WriteLine(note);
            double z = double.Parse(Console.ReadLine());
            return z;
        }
    }
}
