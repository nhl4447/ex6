using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.lesson2
{
    internal class ex2
    {
        //ex1
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Alexandra Abrahmov");
        }
        //ex2
        static void Main1(string[] args)
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine($"Tong cua hai so {a} va {b} la {c}");

        }
        //ex3
        static void Main2(string[] args)
        {
            Console.Write("Nhap so x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so y: ");
            int y = int.Parse(Console.ReadLine());
            int q = x / y;
            int d = x % y;
            Console.WriteLine($"{x} chia {y} = {q} du {d}");

        }
        //ex4
        static void Main3(string[] args)
        {
            /* Write a C# Sharp program to print the results of the specified operations. 
            Test data: • -1 + 4 * 6
                        • (35 + 5) % 7
                           • 14 + -4 * 6 / 11
                           • 2 + 15 / 6 * 1 - 7 % 2
                           Expected Output: 23 5 12 3*/
            Console.WriteLine("-1+4*6={0}", -1 + 4 * 6);
            Console.WriteLine("( 35 + 5 ) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);



        }
        //ex5

        static void Main4(string[] args)
        {
            int a = 2; int b = 4;
            Console.WriteLine($"Truoc khi hoan doi truoc = {a}, sau = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Sau khi hoan doi truoc = {a}, sau = {b}");

        }
        //ex6
        static void Main5(string[] args)
        {
            Console.Write("Nhap so dau: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float second = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float third = float.Parse(Console.ReadLine());
            float sum = first * second * third;
            Console.WriteLine($"Tich cua ba so {first}x{second}x{third}= {sum}");
        }
        //ex7
        static void Main6(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine($"{f}+{s}={f + s}");
            Console.WriteLine($"{f}-{s}={f - s}");
            Console.WriteLine($"{f}*{s}={f * s}");
            Console.WriteLine($"{f}/{s}={f / s}");
            Console.WriteLine($"{f} mod {s}={f % s}");

        }
        //ex8
        static void Main7(string[] args)
        {
            Console.Write("Nhap so dau: ");
            float fi = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float se = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float th = float.Parse(Console.ReadLine());
            Console.Write("Nhap so bon: ");
            float fo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Trung binh cong bon so {fi};{se};{th};{fo} la {(fi + se + th + fo) / 4}");
        }
        //ex9
        static void Main8(string[] args)
        {
            Console.Write("Nhap so dau: ");
            int dau = int.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            int hai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            int cuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"({dau}+{hai}).{cuoi}={(dau + hai) * cuoi} va {dau}.{hai}+{hai}.{cuoi}={dau * hai + hai * cuoi}");


        }
        //ex10
        static void Main9(string[] args)
        {
            Console.Write("Nhap do tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {tuoi}");

        }
        //ex11
        static void Main11(string[] args)
        {
            Console.Write("Nhap mot so: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}\n" + "{0}{0}{0}{0}\n" + "{0} {0} {0} {0}\n" + "{0}{0}{0}{0}", num);

        }
        //ex12
        static void Main12(string[] args)
        {
            Console.Write("Nhap do Celsius: ");
            int ce = int.Parse(Console.ReadLine());
            int kelvin = ce + 273;
            int fahrenheit = ce * 18 / 10 + 32;
            Console.WriteLine($"{ce} do C = {kelvin} K\n" +
                $"{ce} do C = {fahrenheit} F");
        }
        //ex13
        static void Main13(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            Console.Write("Nhap ki tu xoa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuoi sau khi xoa: {str.Remove(n, 1)}");

        }
        //ex14
        static void Main14(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            if (chuoi.Length <= 1)
            {
                Console.WriteLine($"Chuoi moi la: {chuoi}");
            }
            else
            {
                string fchar = chuoi.Substring(0, 1);
                string lchar = chuoi.Substring(chuoi.Length - 1);
                string mchar = chuoi.Substring(1, chuoi.Length - 2);
                Console.WriteLine($"Chuoi moi la: {lchar + mchar + fchar}");
            }

        }
        //ex15
        static void Main15(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            String chu = Console.ReadLine();
            Console.Write("Nhap tu them: ");
            String them = Console.ReadLine();
            Console.WriteLine($"Chuoi moi la: {them + chu + them}");

        }
        //ex16
        static void Main16(string[] args)
        {
            string str = "w3resource";

            string result = str[str.Length - 1] +
                            str.Substring(1, str.Length - 2) +
                            str[0];

            Console.WriteLine(result);
        }
        //ex17
        static void Main17(string[] args)
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();

            string result = str[0] + str + str[0];

            Console.WriteLine(result);
        }
        //ex18
        static void Main18(string[] args)
        {
            Console.Write("Input first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool result = (num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0);

            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine(result);
        }
        //ex19
        static void Main19(string[] args)
        {
            Console.Write("Input first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                sum = sum * 3;
            }

            Console.WriteLine("Result: " + sum);

        }
        //ex20
        static void Main20(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                difference *= 2;
            }

            Console.WriteLine("Result: " + difference);
        }

    }
}

