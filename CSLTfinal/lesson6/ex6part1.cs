using System;
using System.Text;

internal class ex6part1
{
    // bài 1: tính trung bình cộng của mảng
    static double Avg(int[] arr)
    {
        double sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    }


    // bài 2: kiểm tra mảng có chứa giá trị hay không
    static bool ContainsValue(int[] arr, int value)
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


    // bài 3: tìm index của phần tử
    static int FindIndex(int[] arr, int value)
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


    // bài 4: xóa một phần tử khỏi mảng
    static bool RemoveElement(int[] arr, ref int n, int x)
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


    // bài 5: tìm max
    static int FindMax(int[] arr, int n)
    {
        int max = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }


    // bài 5: tìm min
    static int FindMin(int[] arr, int n)
    {
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }


    // bài 6: đảo ngược mảng
    static void ReverseArray(int[] arr, int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
    }


    // bài 7: tìm phần tử trùng lặp
    static void FindDuplicates(int[] arr, int n)
    {
        Console.Write("các phần tử trùng là: ");

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            bool alreadyPrinted = false;

            for (int k = 0; k < i; k++)
            {
                if (arr[k] == arr[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (alreadyPrinted)
            {
                continue;
            }

            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.Write(arr[i] + " ");
                    found = true;
                    break;
                }
            }
        }

        if (!found)
        {
            Console.Write("không có");
        }

        Console.WriteLine();
    }


    // bài 8: xóa phần tử trùng lặp
    static int RemoveDuplicates(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    for (int k = j; k < n - 1; k++)
                    {
                        arr[k] = arr[k + 1];
                    }

                    n--;
                    j--;
                }
            }
        }

        return n;
    }


    // hàm in mảng
    static void PrintArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 8 };
        int n = arr.Length;


        // bài 1
        double tb = Avg(arr);

        Console.WriteLine("trung bình cộng là: " + tb);


        // bài 2
        Console.Write("nhập số cần kiểm tra: ");
        int x = int.Parse(Console.ReadLine());

        bool check = ContainsValue(arr, x);

        if (check)
        {
            Console.WriteLine("mảng có chứa giá trị");
        }
        else
        {
            Console.WriteLine("mảng không chứa giá trị");
        }


        // bài 3
        int index = FindIndex(arr, x);

        if (index != -1)
        {
            Console.WriteLine("index của phần tử là: " + index);
        }
        else
        {
            Console.WriteLine("không tìm thấy phần tử");
        }


        // bài 4
        Console.Write("nhập phần tử cần xóa: ");
        int deleteValue = int.Parse(Console.ReadLine());

        bool removed = RemoveElement(arr, ref n, deleteValue);

        if (removed)
        {
            Console.WriteLine("xóa thành công");

            PrintArray(arr, n);
        }
        else
        {
            Console.WriteLine("không tìm thấy phần tử");
        }


        // bài 5
        int max = FindMax(arr, n);
        int min = FindMin(arr, n);

        Console.WriteLine("max là: " + max);
        Console.WriteLine("min là: " + min);


        // bài 6
        ReverseArray(arr, n);

        Console.Write("mảng sau khi đảo ngược: ");
        PrintArray(arr, n);


        // bài 7
        FindDuplicates(arr, n);


        // bài 8
        n = RemoveDuplicates(arr, n);

        Console.Write("mảng sau khi xóa trùng: ");
        PrintArray(arr, n);
    }
}
