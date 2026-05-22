using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.lesson6
{
    internal class baitap6
    {
        
        static double avg(int[] arr)//1
        {
            double a = 0, sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                a = sum / arr[i];
            }

            return a;
        }
        static bool ContainsValue(int[] arr, int value)//2
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }

            return false;
        }
        static int FindIndex(int[] arr, int value)//3
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }






            static bool xoa_phantu(int[] arr, ref int n, int x)//4
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }



        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.to calculate the average value of array elements.
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double tb = avg(arr);

            Console.WriteLine($"trung binh cong gia tri trong mang la {tb}");
            //2.to test if an array contains a specific value.
            
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.Write("nhap so can tim: ");
                int x = int.Parse(Console.ReadLine());

                bool timthay = ContainsValue(arr, x);

                if (timthay)
                {
                    Console.WriteLine($"mảng chứa giá trị {x}.");// mảng chứa giá trị
                }
                else
                {
                    Console.WriteLine($"mảng ko chứa giá trị {x}.");// mảng ko chứa

                }

            }
            //3. Tìm chỉ số của một phần tử mảng.
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.Write("nhap so can tim: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int index = FindIndex(numbers, x);
                if (index != -1)
                {
                    Console.WriteLine($"chỉ số của phần tử là: {index}");// chỉ số của phần tử là
                }
                else
                {
                    Console.WriteLine("phần tử không tồn tại trong mảng.");// phần tử không tồn tại trong mảng
                }

            }

                //4. tìm phần tử cần xoá, nếu tìm thấy thì xoá và trả về true, nếu không tìm thấy thì trả về false.


            }

        }
    }

