using System;

class Program
{
    static void Main(string[] args)
    {
     

        // bai 1
        Console.WriteLine("bai 1: may tinh");

        Console.Write("nhap so thu nhat: ");
        double so1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("nhap so thu hai: ");
        double so2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("nhap phep toan (+, -, *, /): ");
        char phepToan = Convert.ToChar(Console.ReadLine());

        double ketQua = 0;

        switch (phepToan)
        {
            case '+':
                ketQua = so1 + so2;
                break;

            case '-':
                ketQua = so1 - so2;
                break;

            case '*':
                ketQua = so1 * so2;
                break;

            case '/':
                if (so2 != 0)
                    ketQua = so1 / so2;
                else
                    Console.WriteLine("khong the chia cho 0");
                break;

            default:
                Console.WriteLine("phep toan khong hop le");
                break;
        }

        Console.WriteLine("ket qua = " + ketQua);

        Console.WriteLine();

        // bai 2
        Console.WriteLine("bai 2: x = y^2 + 2y + 1");

        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;

            Console.WriteLine("y = " + y + " => x = " + x);
        }

        Console.WriteLine();

        // bai 3
        Console.WriteLine("bai 3: tinh toc do");

        Console.Write("nhap quang duong (km): ");
        double quangDuong = Convert.ToDouble(Console.ReadLine());

        Console.Write("nhap gio: ");
        int gio = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap phut: ");
        int phut = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap giay: ");
        int giay = Convert.ToInt32(Console.ReadLine());

        double tongGio = gio + (phut / 60.0) + (giay / 3600.0);

        double tocDoKm = quangDuong / tongGio;
        double tocDoMiles = tocDoKm * 0.621371;

        Console.WriteLine("toc do km/h = " + tocDoKm);
        Console.WriteLine("toc do miles/h = " + tocDoMiles);

        Console.WriteLine();

        // bai 4
        Console.WriteLine("bai 4: dien tich va the tich hinh cau");

        Console.Write("nhap ban kinh: ");
        double banKinh = Convert.ToDouble(Console.ReadLine());

        double dienTich = 4 * Math.PI * banKinh * banKinh;
        double theTich = (4.0 / 3.0) * Math.PI * banKinh * banKinh * banKinh;

        Console.WriteLine("dien tich = " + dienTich);
        Console.WriteLine("the tich = " + theTich);

        Console.WriteLine();

        // bai 5
        Console.WriteLine("bai 5: kiem tra ky tu");

        Console.Write("nhap 1 ky tu: ");
        char kyTu = Convert.ToChar(Console.ReadLine());

        if ("aeiouAEIOU".Contains(kyTu))
        {
            Console.WriteLine("day la nguyen am");
        }
        else if (char.IsDigit(kyTu))
        {
            Console.WriteLine("day la chu so");
        }
        else
        {
            Console.WriteLine("day la ky tu khac");
        }

        Console.WriteLine();

        // bai 6
        Console.WriteLine("bai 6: chan le");

        Console.Write("nhap so nguyen: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("so chan");
        else
            Console.WriteLine("so le");

        Console.WriteLine();

        // bai 7
        Console.WriteLine("bai 7: so lon nhat trong 3 so");

        Console.Write("nhap so a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap so b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap so c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        Console.WriteLine("so lon nhat = " + max);

        Console.WriteLine();

        // bai 8
        Console.WriteLine("bai 8: xac dinh goc phan tu");

        Console.Write("nhap toa do x: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap toa do y: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        if (x1 > 0 && y1 > 0)
            Console.WriteLine("thuoc goc phan tu thu 1");

        else if (x1 < 0 && y1 > 0)
            Console.WriteLine("thuoc goc phan tu thu 2");

        else if (x1 < 0 && y1 < 0)
            Console.WriteLine("thuoc goc phan tu thu 3");

        else if (x1 > 0 && y1 < 0)
            Console.WriteLine("thuoc goc phan tu thu 4");

        else
            Console.WriteLine("nam tren truc toa do");

        Console.WriteLine();

        // bai 9
        Console.WriteLine("bai 9: loai tam giac");

        Console.Write("nhap canh a: ");
        int canh1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap canh b: ");
        int canh2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("nhap canh c: ");
        int canh3 = Convert.ToInt32(Console.ReadLine());

        if (canh1 == canh2 && canh2 == canh3)
            Console.WriteLine("tam giac deu");

        else if (canh1 == canh2 || canh1 == canh3 || canh2 == canh3)
            Console.WriteLine("tam giac can");

        else
            Console.WriteLine("tam giac thuong");

        Console.WriteLine();

        // bai 10
        Console.WriteLine("bai 10: tinh tong va trung binh 10 so");

        int tong = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("nhap so thu " + i + ": ");
            int so = Convert.ToInt32(Console.ReadLine());

            tong += so;
        }

        double trungBinh = tong / 10.0;

        Console.WriteLine("tong = " + tong);
        Console.WriteLine("trung binh = " + trungBinh);

        Console.WriteLine();

        // bai 11
        Console.WriteLine("bai 11: bang cuu chuong");

        Console.Write("nhap so: ");
        int bang = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(bang + " x " + i + " = " + (bang * i));
        }

        Console.WriteLine();

        // bai 12
        Console.WriteLine("bai 12: tam giac so");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        // bai 13
        Console.WriteLine("bai 13: harmonic series");

        Console.Write("nhap n: ");
        int nHarmonic = Convert.ToInt32(Console.ReadLine());

        double tongHarmonic = 0;

        for (int i = 1; i <= nHarmonic; i++)
        {
            tongHarmonic += 1.0 / i;
        }

        Console.WriteLine("tong harmonic = " + tongHarmonic);

        Console.WriteLine();

        // bai 14
        Console.WriteLine("bai 14: perfect number");

        Console.Write("nhap so: ");
        int perfect = Convert.ToInt32(Console.ReadLine());

        int tongUoc = 0;

        for (int i = 1; i < perfect; i++)
        {
            if (perfect % i == 0)
            {
                tongUoc += i;
            }
        }

        if (tongUoc == perfect)
            Console.WriteLine("day la perfect number");
        else
            Console.WriteLine("khong phai perfect number");

        Console.WriteLine();

        // bai 15
        Console.WriteLine("bai 15: so nguyen to");

        Console.Write("nhap so: ");
        int soNguyenTo = Convert.ToInt32(Console.ReadLine());

        bool laSoNguyenTo = true;

        if (soNguyenTo < 2)
        {
            laSoNguyenTo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(soNguyenTo); i++)
            {
                if (soNguyenTo % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }
        }

        if (laSoNguyenTo)
            Console.WriteLine("la so nguyen to");
        else
            Console.WriteLine("khong phai so nguyen to");
    }
}