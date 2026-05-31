using System;

class program
{
    static void Main1(string[] args)
    {
        Console.WriteLine("========== 10 BÀI TẬP C# ==========\n");

        Bai1_TongHaiSo();
        Bai2_HoanViHaiBien();
        Bai3_NhanSoThapPhan();
        Bai4_FeetToMeter();
        Bai5_CelsiusFahrenheit();
        Bai6_KichThuocKieuDuLieu();
        Bai7_InGiaTriASCII();
        Bai8_DienTichHinhTron();
        Bai9_DienTichHinhVuong();
        Bai10_NgayRaNamTuanNgay();
    }

    // ── Bài 1: Cộng hai số ──────────────────────────────────────
    static void Bai1_TongHaiSo()
    {
        Console.WriteLine("── Bài 1: Cộng hai số ──");
        Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng = {a + b}\n");
    }

    // ── Bài 2: Hoán vị hai biến ─────────────────────────────────
    static void Bai2_HoanViHaiBien()
    {
        Console.WriteLine("── Bài 2: Hoán vị hai biến ──");
        Console.Write("Nhập x: "); int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập y: "); int y = int.Parse(Console.ReadLine());

        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"Sau hoán vị: x = {x}, y = {y}\n");
    }

    // ── Bài 3: Nhân hai số thực ─────────────────────────────────
    static void Bai3_NhanSoThapPhan()
    {
        Console.WriteLine("── Bài 3: Nhân hai số thực ──");
        Console.Write("Nhập a: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b: "); double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"a × b = {a * b}\n");
    }

    // ── Bài 4: Feet → Mét ───────────────────────────────────────
    static void Bai4_FeetToMeter()
    {
        Console.WriteLine("── Bài 4: Feet → Mét ──");
        Console.Write("Nhập số feet: "); double feet = double.Parse(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {feet * 0.3048:F4} mét\n");
    }

    // ── Bài 5: Celsius ↔ Fahrenheit ─────────────────────────────
    static void Bai5_CelsiusFahrenheit()
    {
        Console.WriteLine("── Bài 5: Celsius ↔ Fahrenheit ──");
        Console.Write("Nhập °C: "); double c = double.Parse(Console.ReadLine());
        double f = c * 9 / 5 + 32;
        Console.WriteLine($"{c}°C = {f:F2}°F");

        Console.Write("Nhập °F: "); f = double.Parse(Console.ReadLine());
        c = (f - 32) * 5 / 9;
        Console.WriteLine($"{f}°F = {c:F2}°C\n");
    }

    // ── Bài 6: Kích thước các kiểu dữ liệu ─────────────────────
    static void Bai6_KichThuocKieuDuLieu()
    {
        Console.WriteLine("── Bài 6: Kích thước kiểu dữ liệu ──");
        Console.WriteLine($"bool   : {sizeof(bool)} byte");
        Console.WriteLine($"byte   : {sizeof(byte)} byte");
        Console.WriteLine($"char   : {sizeof(char)} byte");
        Console.WriteLine($"int    : {sizeof(int)} byte");
        Console.WriteLine($"long   : {sizeof(long)} byte");
        Console.WriteLine($"float  : {sizeof(float)} byte");
        Console.WriteLine($"double : {sizeof(double)} byte");
        Console.WriteLine($"decimal: {sizeof(decimal)} byte\n");
    }

    // ── Bài 7: In giá trị ASCII ─────────────────────────────────
    static void Bai7_InGiaTriASCII()
    {
        Console.WriteLine("── Bài 7: Giá trị ASCII ──");
        Console.Write("Nhập một ký tự: "); char ch = Console.ReadLine()[0];
        Console.WriteLine($"ASCII của '{ch}' = {(int)ch}\n");
    }

    // ── Bài 8: Diện tích hình tròn ──────────────────────────────
    static void Bai8_DienTichHinhTron()
    {
        Console.WriteLine("── Bài 8: Diện tích hình tròn ──");
        Console.Write("Nhập bán kính r: "); double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Diện tích = {Math.PI * r * r:F4}\n");
    }

    // ── Bài 9: Diện tích hình vuông ─────────────────────────────
    static void Bai9_DienTichHinhVuong()
    {
        Console.WriteLine("── Bài 9: Diện tích hình vuông ──");
        Console.Write("Nhập cạnh a: "); double a = double.Parse(Console.ReadLine());
        Console.WriteLine($"Diện tích = {a * a:F4}\n");
    }

    // ── Bài 10: Đổi ngày → năm, tuần, ngày ─────────────────────
    static void Bai10_NgayRaNamTuanNgay()
    {
        Console.WriteLine("── Bài 10: Ngày → Năm / Tuần / Ngày ──");
        Console.Write("Nhập số ngày: "); int tongNgay = int.Parse(Console.ReadLine());

        int nam = tongNgay / 365;
        int tuan = (tongNgay % 365) / 7;
        int ngay = (tongNgay % 365) % 7;

        Console.WriteLine($"{tongNgay} ngày = {nam} năm, {tuan} tuần, {ngay} ngày\n");
    }
}