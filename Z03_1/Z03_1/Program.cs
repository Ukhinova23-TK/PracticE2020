﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z03_1
{
    class Program
    {
        static int F(int x)
        {
            string num = x.ToString();
            if (num[0] == '-' && num.Length == 3)
            {
                return Convert.ToInt32(num[0].ToString() + num[2].ToString() + num[1].ToString());
            }
            else if (num.Length == 2)
            {
                return Convert.ToInt32(num[1].ToString() + num[0].ToString());
            }
            else
            {
                Console.WriteLine("Число не двузначное");
                return x;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write(F(num));
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
