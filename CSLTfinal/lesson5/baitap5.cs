using System;
using System.Text;

class BaiTapHam
{
    
    // PHẦN 1: BÀI TẬP CÓ HƯỚNG DẪN (1 - 5)
  

    // Bài 1: Tính tổng hai số nguyên
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    // Bài 2: Kiểm tra số chẵn lẻ
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }

    // Bài 3: Tìm số lớn nhất trong ba số
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    // Bài 4: Tính giai thừa
    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;
        for (int i = 1; i <= n; i++)
            ketQua *= i;
        return ketQua;
    }

    // Bài 5: Đảo ngược chuỗi
    static string DaoNguocChuoi(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    
    // PHẦN 2: BÀI TẬP CÓ KẾT QUẢ MẪU (Bài 6 - 20)
    

    // Bài 6: Kiểm tra số nguyên tố
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    // Bài 7: In dãy Fibonacci
    static void InFibonacci(int n)
    {
        long a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            long temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }

    // Bài 8: Đếm nguyên âm trong chuỗi
    static int DemNguyenAm(string s)
    {
        int count = 0;
        string nguyenAm = "aeiouAEIOU";
        foreach (char c in s)
            if (nguyenAm.Contains(c)) count++;
        return count;
    }

    // Bài 9: Tính lũy thừa (không dùng Math.Pow)
    static double TinhLuyThua(double x, int y)
    {
        double ketQua = 1;
        for (int i = 0; i < Math.Abs(y); i++)
            ketQua *= x;
        return y < 0 ? 1 / ketQua : ketQua;
    }

    // Bài 10: Tính điểm trung bình mảng
    static double TinhTrungBinh(int[] arr)
    {
        double tong = 0;
        foreach (int x in arr) tong += x;
        return tong / arr.Length;
    }

    // Bài 11: Kiểm tra Palindrome
    static bool KiemTraDoiXung(string s)
    {
        string dao = DaoNguocChuoi(s);
        return s.Equals(dao, StringComparison.OrdinalIgnoreCase);
    }

    // Bài 12: Celsius sang Fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return c * 9.0 / 5.0 + 32;
    }

    // Bài 13: Tìm giá trị nhỏ nhất trong mảng
    static int TimMin(int[] arr)
    {
        int min = arr[0];
        foreach (int x in arr)
            if (x < min) min = x;
        return min;
    }

    // Bài 14: Tính tổng các chữ số
    static int TongCacChuSo(int n)
    {
        n = Math.Abs(n);
        int tong = 0;
        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }
        return tong;
    }

    // Bài 15: Sắp xếp mảng tăng dần
    static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }

    // Bài 16: Xóa ký tự trùng lặp
    static string XoaTrungLap(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
            if (sb.ToString().IndexOf(c) < 0) sb.Append(c);
        return sb.ToString();
    }

    // Bài 17: Ước chung lớn nhất (Euclid)
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Bài 18: Thập phân sang nhị phân
    static string DecimalToBinary(int n)
    {
        if (n == 0) return "0";
        string kq = "";
        while (n > 0)
        {
            kq = (n % 2) + kq;
            n /= 2;
        }
        return kq;
    }

    // Bài 19: Kiểm tra năm nhuận
    static bool KiemTraNamNhuan(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Bài 20: Đếm số từ trong câu
    static int DemSoTu(string sentence)
    {
        string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

   
    // MAIN - CHẠY THỬ TẤT CẢ BÀI
    
    static void Main(string[] args)
    {
        Console.WriteLine("========== PHẦN 1: BÀI CÓ HƯỚNG DẪN ==========\n");

        Console.WriteLine("Bài 1 - TinhTong(3, 5) = " + TinhTong(3, 5));

        Console.WriteLine("Bài 2 - KiemTraChan(4) = " + KiemTraChan(4));
        Console.WriteLine("       KiemTraChan(7) = " + KiemTraChan(7));

        Console.WriteLine("Bài 3 - TimMax(3, 9, 5) = " + TimMax(3, 9, 5));

        Console.WriteLine("Bài 4 - TinhGiaiThua(6) = " + TinhGiaiThua(6));

        Console.WriteLine("Bài 5 - DaoNguocChuoi(\"hello\") = " + DaoNguocChuoi("hello"));

        Console.WriteLine("\n========== PHẦN 2: BÀI CÓ KẾT QUẢ MẪU ==========\n");

        Console.WriteLine("Bài 6  - KiemTraNguyenTo(7)  = " + KiemTraNguyenTo(7));
        Console.WriteLine("         KiemTraNguyenTo(10) = " + KiemTraNguyenTo(10));

        Console.Write("Bài 7  - InFibonacci(6)      = ");
        InFibonacci(6);

        Console.WriteLine("Bài 8  - DemNguyenAm(\"Hello World\") = " + DemNguyenAm("Hello World"));

        Console.WriteLine("Bài 9  - TinhLuyThua(2, 3)  = " + TinhLuyThua(2, 3));

        Console.WriteLine("Bài 10 - TinhTrungBinh([4,5,6,7]) = " + TinhTrungBinh(new int[] { 4, 5, 6, 7 }));

        Console.WriteLine("Bài 11 - KiemTraDoiXung(\"radar\") = " + KiemTraDoiXung("radar"));
        Console.WriteLine("         KiemTraDoiXung(\"hello\") = " + KiemTraDoiXung("hello"));

        Console.WriteLine("Bài 12 - CelsiusToFahrenheit(25) = " + CelsiusToFahrenheit(25));

        Console.WriteLine("Bài 13 - TimMin([10,5,8,2,9]) = " + TimMin(new int[] { 10, 5, 8, 2, 9 }));

        Console.WriteLine("Bài 14 - TongCacChuSo(1234) = " + TongCacChuSo(1234));

        Console.Write("Bài 15 - SapXepMang([3,1,4,2]) = ");
        SapXepMang(new int[] { 3, 1, 4, 2 });

        Console.WriteLine("Bài 16 - XoaTrungLap(\"programming\") = " + XoaTrungLap("programming"));

        Console.WriteLine("Bài 17 - UCLN(12, 18) = " + UCLN(12, 18));

        Console.WriteLine("Bài 18 - DecimalToBinary(10) = " + DecimalToBinary(10));

        Console.WriteLine("Bài 19 - KiemTraNamNhuan(2024) = " + KiemTraNamNhuan(2024));
        Console.WriteLine("         KiemTraNamNhuan(2023) = " + KiemTraNamNhuan(2023));

        Console.WriteLine("Bài 20 - DemSoTu(\"Học lập trình C# rất thú vị\") = " + DemSoTu("Học lập trình C# rất thú vị"));
    }
}