// Console.WriteLine("Xin chao the gioi, toi la DungX!");

/* int a = 5;
int b = 10;
double c = 5.5;
double d = a + b - c;
Console.WriteLine(a + b -c - d);

a = 5;
b = -5;
Console.WriteLine(a + b); */

/*
Đây là chương trình đầu tiên của tôi
Tôi đang học C# cùng AI dễ thương =))
*/


//Excercise
/*
string Ten = "Dungx";
int Tuoi = 26;
Console.WriteLine("Toi ten la " + Ten  + "\nNam nay toi " +  Tuoi + " tuoi!"); */

//Input
/*
Console.Write("Tên bạn là gì: ");
string ten = Console.ReadLine();
Console.Write("Năm nay bạn bao nhiêu tuổi:");
string Nhap_tuoi = Console.ReadLine();
int tuoi = int.Parse(Nhap_tuoi);
Console.WriteLine("Toi ten la: " + ten + "\nNam nay toi " + tuoi + "tuoi."); */

//Reality =)) just get used to it
/*
using System;
namespace HelloUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Tên bạn là gì: ");
            string ten = Console.ReadLine();

            Console.WriteLine("Chào bạn, " + ten + "!");
        }
    }
} */

/* int a = 5;
int b = 3;
int c = a++;
int d = b--;

Console.WriteLine((double)a/b); */

//Excercises 1

/* Console.Write("Nhap so thu nhat: ");
string s1 = Console.ReadLine();
double st1 = int.Parse(s1);
Console.Write("Nhap so thu hai: ");
string s2 = Console.ReadLine();
double st2 = int.Parse(s2);

Console.WriteLine(" Tong 2 so la: " + (st1 + st2));
Console.WriteLine(" Hieu 2 so la: " + (st1 - st2));
Console.WriteLine(" Tich 2 so la: " + (st1 * st2));
Console.WriteLine(" Thuong 2 so la: " + (st1 / st2));
Console.WriteLine(" So du cua 2 so la: " + (st1 % st2)); */

//Excercises 2

Console.Write("Nhap so tuoi:");
string str_st = Console.ReadLine();
int st = int.Parse(str_st);
if (st < 18)
{ Console.WriteLine("Chua du tuoi truong thanh!"); }
else if (18 <= st && st <=60)
{ Console.WriteLine("Thuoc tuoi truong thanh!"); }
else { Console.WriteLine("Thuoc nguoi gia!"); }