using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.lesson5
{
    internal class baitap5
    {

        //Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.
       


        class Program
    {
           
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
          
        static void Main(string[] args)
               
        {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int ketQua = TinhTong(a, b);

            Console.WriteLine("tong la: " + ketQua);
        }
    }
}
}
