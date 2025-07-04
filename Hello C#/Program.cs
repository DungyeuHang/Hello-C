//* Bai 1 ---------------------------- print Hello World! ---------------------------------

// Console.WriteLine("Xin chao the gioi, toi la DungX!");

//** --------------------------------------- Bai 2 Biến ------------------------------------
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



//*** ------------------------------------------------Bài 3 input- nhập--------------------------
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

//**** ------------------------------------  Bài 4 + - * / %---------------------------------------------------

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

//***** ----------------------------------------  Bài 5 if else if else - while - for -------------------------------


// if
/* 

if (điều_kiện)
{ // nếu điều kiện đúng}
else
{ // nếu điều kiện sai }

*/

/* Console.Write("Nhap so tuoi:");
string str_st = Console.ReadLine();
int st = int.Parse(str_st);
if (st < 18)
{ Console.WriteLine("Chua du tuoi truong thanh!"); }
else if (18 <= st && st <=60)
{ Console.WriteLine("Thuoc tuoi truong thanh!"); }
else { Console.WriteLine("Thuoc nguoi gia!"); } */
//Test change github

/*
int i = 5+2;
if (i < 5)
{ Console.WriteLine("nho hon 5"); }
else if (i == 5)
{ Console.WriteLine(" bang 5"); }
else
{ Console.WriteLine(" lon hon 5"); } 
*/

/* while (điều_kiện)
{
    // lặp lại mã khi điều kiện còn đúng
}
*/

/*
int i = 1;
while (i <= 5)
{ Console.WriteLine("Lan thu: " + i);
    i++;
}
*/

/* for (int i = 0; i < số_lần; i++)
{
    // phần thân lặp
}
*/

/*
int i = 0;
for (; i <= 5; i++)
{ Console.WriteLine(i); }
*/



//-------------------------------------****** Bài 6  Hàm (Method) *****---------------------
/* <kiểu_trả_về> <tên_hàm>(<tham_số>)
{
    // phần thân hàm
    return <giá_trị>; // nếu có
}
*/

/* int Cong2so( int a , int b)
    { return a + b; }

int Tong = Cong2so(5, 2);
Console.WriteLine(Tong); */

/*
class TinhToan
{
    public static int Cong(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int i = TinhToan.Cong(6, 5);
        Console.WriteLine(i);
    }
}
*/

/*
class MayTinh
{
    private int BiMat = 123;

    public void HienThiBiMat()
    {
        Console.WriteLine(BiMat); // ✅ OK vì gọi bên trong class
    }
}
*/

/*
void Chao(string ten)
{
    Console.WriteLine("Xin chào " + ten);
}

Chao("Dung");
*/

/*
int[] so = new int[3];     // mảng 3 phần tử rỗng
int[] diem = { 7, 8, 9, 15 };  // mảng khởi tạo sẵn

Console.WriteLine(diem[0]); // 👉 in ra 7
diem[1] = 10;               // 👉 sửa phần tử thứ 2

Console.WriteLine(diem[3]);

Console.WriteLine(so);




foreach (int d in diem)
{
    Console.WriteLine("Điểm: " + d);
}

*/
/*
 using System.Collections.Generic;

List<kiểu_dữ_liệu> tên_list = new List<kiểu_dữ_liệu>();
*/
/* 
tên_list.Add(giá_trị);        // Thêm phần tử vào cuối
tên_list.Remove(giá_trị);     // Xoá phần tử (nếu có)
tên_list.RemoveAt(vị_trí);    // Xoá phần tử theo chỉ số
tên_list.Count;               // Đếm số phần tử
tên_list.Clear();             // Xoá toàn bộ phần tử
tên_list[vị_trí];             // Lấy giá trị theo chỉ số

 */

/*

List<string> ten = new List<string>();
ten.Add("Dũng");
ten.Add("Hằng");
*/

/*
 foreach (kiểu_dữ_liệu biến in tên_list)
{
    // xử lý biến
}
*/

/*
foreach (string t in ten)
{
    Console.WriteLine("Tên: " + t);
}
*/

/*
 * switch (biến_hoặc_biểu_thức)
{
    case giá_trị_1:
        // hành động 1
        break;

    case giá_trị_2:
        // hành động 2
        break;

    default:
        // hành động mặc định nếu không khớp case nào
        break;
}
*/
/*
int ngay = 1;

switch (ngay)
{
    case 1:
        Console.WriteLine("Thứ Hai");
        break;
    case 2:
        Console.WriteLine("Thứ Ba");
        break;
    case 3:
        Console.WriteLine("Thứ Tư");
        break;
    default:
        Console.WriteLine("Không biết ngày");
        break;
}
*/


// ******* ------------------ Bài 7: Class + Object --------------------- *********
/* class TênClass
{
    // Thuộc tính (property)
    kiểu_dữ_liệu tên_biến;

    // Hàm khởi tạo (constructor)
    public TênClass()
    {
        // khởi tạo giá trị mặc định
    }

    // Phương thức (method)
    kiểu_trả_về TênHàm(tham_số)
    {
        // thân hàm
        return kết_quả;
    }
}

TênClass tên_object = new TênClass();

tên_object.tên_biến = giá_trị;
tên_object.TênHàm(tham_số);

class TênClass
{
    kiểu_dữ_liệu tên_biến;

    public TênClass(kiểu_dữ_liệu tham_so)
    {
        tên_biến = tham_so;
    }
}

TênClass obj = new TênClass(giá_trị);
*/

/*
class SinhVien
{
    // 🧱 Thuộc tính (property)
    public string Ten;
    public int Tuoi;
    public double DiemTB;

    // 🛠 Hàm khởi tạo (constructor)
    public SinhVien(string ten, int tuoi, double diem)
    {
        Ten = ten;
        Tuoi = tuoi;
        DiemTB = diem;
    }

    // 📣 Hàm in thông tin
    public void HienThiThongTin()
    {
        Console.WriteLine($"Tên: {Ten}, Tuổi: {Tuoi}, Điểm TB: {DiemTB}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ✨ Tạo đối tượng SinhVien
        SinhVien sv1 = new SinhVien("Dũng", 26, 8.5);
        SinhVien sv2 = new SinhVien("Hằng", 27, 9.9);

        // 📣 Gọi phương thức hiển thị
        sv1.HienThiThongTin();
        sv2.HienThiThongTin();
    }
}
*/

using System;
using System.Collections.Generic;

class SinhVien
{
    public string Ten;
    public int Tuoi;
    public double DiemTB;

    public SinhVien(string ten, int tuoi, double diem)
    {
        Ten = ten;
        Tuoi = tuoi;
        DiemTB = diem;
    }

    // Hàm tính xếp loại
    public string XepLoai()
    {
        if (DiemTB >= 8) return "Giỏi";
        else if (DiemTB >= 6.5) return "Khá";
        else if (DiemTB >= 5) return "Trung bình";
        else return "Yếu";
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Tên: {Ten}, Tuổi: {Tuoi}, Điểm TB: {DiemTB}, Xếp loại: {XepLoai()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách sinh viên
        List<SinhVien> danhSach = new List<SinhVien>();

        // Thêm vài sinh viên
        danhSach.Add(new SinhVien("Dũng", 20, 8.5));
        danhSach.Add(new SinhVien("Hằng", 19, 9.9));
        danhSach.Add(new SinhVien("Hùng", 21, 4.9));

        // Duyệt danh sách và in thông tin
        foreach (SinhVien sv in danhSach)
        {
            sv.HienThiThongTin();
        }
    }
}





