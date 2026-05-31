using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.lesson7;

internal class bai7
{
    //Create an integer matrix N x M(N, M was prompted from user) randomly.

    static int[,] Nhapmang_ngaunhien(int rows, int columns)

    {
        int[,] a = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                a[i, j] = random.Next(1, 100); // Tạo số ngẫu nhiên từ 1 đến 99
            }
        }

        return a;



    }
    public static void Main1(string[] args)
    {
        Console.WriteLine("nhap so dong: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so cot: "); int m = int.Parse(Console.ReadLine());

        int[,] a = Nhapmang_ngaunhien(n, m);
        Console.WriteLine("Mang ngau nhien:");
        InMang(a);


    }




    /*Bài 1: Nhập và xuất mảng
    • Mô tả: Viết chương trình nhập vào một mảng gồm $n$ số nguyên và in các phần tử của mảng đó ra
    màn hình trên cùng một dòng, cách nhau bởi dấu cách.
    • Đầu vào (Input): *Dòng đầu tiên chứa số nguyên dương $n$ ($1 \le n \le 100$).
    o Dòng thứ hai chứa $n$ số nguyên cách nhau bởi dấu cách.
    • Đầu ra (Output): Dòng duy nhất chứa $n$ số nguyên vừa nhập.*/
    static void InMang(int[,] a)
    {
        int rows = a.GetLength(0);
        int columns = a.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    /*Bài 2: Tính tổng và trung bình
    • Mô tả: Viết chương trình nhập vào một mảng gồm $n$ số thực và in ra tổng và trung bình cộng của các phần tử.
    • Đầu vào (Input): *Dòng đầu tiên chứa số nguyên dương $n$ ($1 \le n \le 100$).
    o Dòng thứ hai chứa $n$ số thực cách nhau bởi dấu cách.
    • Đầu ra (Output): Dòng duy nhất chứa tổng và trung bình cộng của các phần tử, mỗi giá trị in với 2 chữ số thập phân.*/
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];

        string[] input = Console.ReadLine().Split(' ');

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(input[i]);
            sum += arr[i];
        }

        double avg = sum / n;

        Console.WriteLine($"{sum:F2} {avg:F2}");
    }
    /*ex3 Bài 3: Tìm số lớn nhất và nhỏ nhất
• Mô tả: Tìm giá trị lớn nhất (Max) và giá trị nhỏ nhất (Min) của một mảng số nguyên.
• Đầu vào (Input): Số nguyên $n$ và mảng gồm $n$ số nguyên.
• Đầu ra (Output): Hai số nguyên tương ứng là Max và Min cách nhau một dấu cách.*/
    static void Main1()
    {
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];

        string[] input = Console.ReadLine().Split(' ');

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(input[i]);
            sum += arr[i];
        }

        double avg = sum / n;

        Console.WriteLine($"{sum:F2} {avg:F2}");
    }
    /*ex4 Bài 4: Đếm số chẵn và số lẻ
• Mô tả: Đếm xem trong mảng có bao nhiêu chữ số chẵn và bao nhiêu chữ số lẻ.
• Đầu vào (Input): Số nguyên $n$ và mảng gồm $n$ số nguyên.
• Đầu ra (Output): Số lượng số chẵn và số lẻ cách nhau một dấu cách.*/
    static void Main3()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        string[] input = Console.ReadLine().Split(' ');

        int even = 0;
        int odd = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);

            if (arr[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine($"{even} {odd}");
    }
    /*ex5 Bài 5: Tìm kiếm một số trong mảng
• Mô tả: Nhập vào mảng $n$ phần tử và một số nguyên $x$. Kiểm tra xem $x$ có xuất hiện trong mảng
không. Nếu có, in ra vị trí (chỉ số) đầu tiên của $x$ (giả sử mảng bắt đầu từ vị trí 0). Nếu không, in ra -
1.
• Đầu vào (Input): * Dòng 1: Số nguyên $n$ và số nguyên $x$.
o Dòng 2: Mảng $n$ số nguyên.
• Đầu ra (Output): Vị trí tìm thấy hoặc -1.*/
    static void Main5()
    {
        string[] first = Console.ReadLine().Split(' ');

        int n = int.Parse(first[0]);
        int x = int.Parse(first[1]);

        int[] arr = new int[n];

        string[] input = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(-1);
    }



    // BÀI 6: ĐẢO NGƯỢC MẢNG
    static void Main6()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int left = 0, right = n - 1;

        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine(string.Join(" ", a));
    }

    // BÀI 7: KIỂM TRA MẢNG ĐỐI XỨNG 
    static void Bai7()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        bool ok = true;
        for (int i = 0; i < n / 2; i++)
            if (a[i] != a[n - 1 - i]) { ok = false; break; }

        Console.WriteLine(ok ? "YES" : "NO");
    }

    /*  Bài 8: Liệt kê các số nguyên tố trong mảng
• Mô tả: Tìm và in ra tất cả các số nguyên tố xuất hiện trong mảng.
• Đầu vào(Input): Số nguyên $n$ và mảng gồm $n$ số nguyên dương.
• Đầu ra(Output): Các số nguyên tố trong mảng theo thứ tự xuất hiện, cách nhau một dấu cách.Nếu
không có số nào, in ra "EMPTY". */
    static void Bai8()
    {
        // Add this helper inside the same class (e.g., after Bai8 or near other helpers)
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0) return false;
            return true;
        }

        //BÀI 9: TÁCH MẢNG CHẴN - LẺ 
        static void Bai9()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0) Console.Write(a[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                if (a[i] % 2 != 0) Console.Write(a[i] + " ");
        }

        //  BÀI 10: SẮP XẾP TĂNG DẦN VÀ GIẢM DẦN
        static void Bai10()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (a[j] > a[j + 1])
                    { int temp = a[j]; a[j] = a[j + 1]; a[j + 1] = temp; }

            Console.WriteLine(string.Join(" ", a));
            for (int i = n - 1; i >= 0; i--) Console.Write(a[i] + " ");
        }

        // BÀI 11: CHÈN PHẦN TỬ VÀO MẢNG ĐÃ SẮP XẾP
        static void Bai11()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]), x = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = new int[n + 1];

            int i = 0, j = 0;
            while (i < n && a[i] < x) { b[j] = a[i]; i++; j++; }
            b[j++] = x;
            while (i < n) { b[j] = a[i]; i++; j++; }

            Console.WriteLine(string.Join(" ", b));
        }

        //BÀI 12: XÓA PHẦN TỬ TẠI VỊ TRÍ K
        static void Bai12()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]), k = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
                if (i != k) Console.Write(a[i] + " ");
        }

        // BÀI 13: ĐẾM TẦN SUẤT XUẤT HIỆN
        static void Bai13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[] counted = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (counted[i]) continue;
                int count = 1;
                for (int j = i + 1; j < n; j++)
                    if (a[i] == a[j]) { count++; counted[j] = true; }
                Console.WriteLine(a[i] + ": " + count);
            }
        }

        // BÀI 14: TÌM PHẦN TỬ XUẤT HIỆN NHIỀU NHẤT 
        static void Bai14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int bestValue = a[0], bestCount = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                    if (a[i] == a[j]) count++;
                if (count > bestCount || (count == bestCount && a[i] < bestValue))
                { bestCount = count; bestValue = a[i]; }
            }

            Console.WriteLine(bestValue);
        }

        // BÀI 15: TRỘN HAI MẢNG ĐÃ SẮP XẾP
        static void Bai15()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]), m = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] c = new int[n + m];

            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
                c[k++] = (a[i] <= b[j]) ? a[i++] : b[j++];
            while (i < n) c[k++] = a[i++];
            while (j < m) c[k++] = b[j++];

            Console.WriteLine(string.Join(" ", c));
        }

        //  BÀI 16: DÃY CON LIÊN TIẾP TĂNG DÀI NHẤT
        static void Bai16()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int currentLen = 1, maxLen = 1;
            for (int i = 1; i < n; i++)
            {
                currentLen = (a[i] > a[i - 1]) ? currentLen + 1 : 1;
                if (currentLen > maxLen) maxLen = currentLen;
            }

            Console.WriteLine(maxLen);
        }

        //BÀI 17: TỔNG LỚN NHẤT CỦA DÃY CON LIÊN TIẾP 
        static void Bai17()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int currentSum = a[0], maxSum = a[0];
            for (int i = 1; i < n; i++)
            {
                currentSum = Math.Max(a[i], currentSum + a[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            Console.WriteLine(maxSum);
        }

        // BÀI 18: TÌM CẶP SỐ CÓ TỔNG BẰNG X 
        static void Bai18()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]), x = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] + a[j] == x)
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine(i + " " + j);
                        return;
                    }

            Console.WriteLine("NO");
        }

        /*Bài 19: Dịch chuyển mảng xoay vòng k phần tử
    • Mô tả: Dịch chuyển toàn bộ phần tử của mảng sang phải xoay vòng $k$ lần. (Phần tử ở cuối mảng khi
    dịch phải sẽ vòng về đầu mảng).
    • Đầu vào(Input): Số nguyên $n$, số bước dịch $k$ và mảng $n$ phần tử.
    • Đầu ra (Output): Mảng sau khi dịch chuyển xoay vòng.
    • Gợi ý: Cách tối ưu không dùng mảng phụ: Đảo ngược toàn bộ mảng, sau đó đảo ngược $k\%n$ phần
    tử đầu tiên, cuối cùng đảo ngược các phần tử còn lại.*/
        static void Bai19()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]), k = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            k = k % n;
            // Đảo ngược toàn bộ mảng
            Array.Reverse(a);
            // Đảo ngược k phần tử đầu tiên
            Array.Reverse(a, 0, k);
            // Đảo ngược phần còn lại
            Array.Reverse(a, k, n - k);
            Console.WriteLine(string.Join(" ", a));
        }

        //  BÀI 20: TÌM SỐ NGUYÊN DƯƠNG NHỎ NHẤT CÒN THIẾU 
        static void Bai20()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[] mark = new bool[n + 2];

            for (int i = 0; i < n; i++)
                if (a[i] > 0 && a[i] <= n + 1) mark[a[i]] = true;

            for (int i = 1; i <= n + 1; i++)
                if (!mark[i]) { Console.WriteLine(i); return; }
        }
    }
}

   
    


