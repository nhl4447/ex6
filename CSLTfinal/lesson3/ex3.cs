using System;

namespace BaiTapTongHop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

      
            // bài 1
            

            Console.WriteLine("Bài 1: Phép toán cơ bản");

            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập phép toán (+ - * /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Không thể chia cho 0");
                    }
                    break;

                default:
                    Console.WriteLine("Phép toán không hợp lệ");
                    break;
            }

            Console.WriteLine("Kết quả = " + result);




            // bài 2
      

            Console.WriteLine("\nBài 2: y = y^2 + 2y + 1");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;

                Console.WriteLine("y = " + y + " => x = " + x);
            }




     
            // bài 3
           

            Console.WriteLine("\nBài 3: Tính vận tốc");

            Console.Write("Nhập quãng đường (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập giờ: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập phút: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập giây: ");
            int second = Convert.ToInt32(Console.ReadLine());

            double totalHours = hour + (minute / 60.0) + (second / 3600.0);

            double speedKm = distance / totalHours;

            double speedMiles = speedKm * 0.621371;

            Console.WriteLine("Tốc độ km/h = " + speedKm);
            Console.WriteLine("Tốc độ miles/h = " + speedMiles);




         
            // bài 4
       

            Console.WriteLine("\nBài 4: Hình cầu");

            Console.Write("Nhập bán kính: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double surfaceArea = 4 * Math.PI * r * r;

            double volume = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine("Diện tích bề mặt = " + surfaceArea);
            Console.WriteLine("Thể tích = " + volume);




       
            // bài 5
           

            Console.WriteLine("\nBài 5: Kiểm tra ký tự");

            Console.Write("Nhập một ký tự: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("Đây là nguyên âm");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Đây là chữ số");
            }
            else
            {
                Console.WriteLine("Đây là ký tự khác");
            }
        }
    }
}
