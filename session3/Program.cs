// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hello, World!");
#region if-else statement       
// Nhập số nguyên từ bàn phím. In ra số đó là số lẻ hay số chẵn 
// input 
// Console.Write("Moi ban nhap so: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// if(formatNumber % 2 == 0) {
//     Console.WriteLine($"Số bạn nhập vào là: {number} là số chẵn");
// }
// else{
//     Console.WriteLine($"Số bạn nhập vào là: {number} là số lẻ");
// }
#endregion
#region Truthy
//truthy:

int day = 5;
if (day != 0 )
{
    Console.WriteLine("Truthy");
}
#endregion
#region bai tap 

// nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// >=9: Xuất sắc
// 8 <= điểm < 9: giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm <6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém
Console.WriteLine("Moi ban nhap diem Trung Binh");
string? diemTrungBinh = Console.ReadLine();
double formatDiem = Convert.ToDouble(diemTrungBinh);
if(formatDiem >= 9){
    Console.WriteLine("Xuat xac"); 
}
else if (formatDiem >= 8 && formatDiem < 9){
Console.WriteLine("Gioi");
}
//để kết hợp 2 hoặc nhiều điều kiện
// && => và
// || => hoặc 
else if (formatDiem >= 6.5 && formatDiem < 8){
    Console.WriteLine("Kha");
}
else if (formatDiem >= 5 && formatDiem < 6.5){
    Console.WriteLine("Trung Binh");
}
else if (formatDiem > 3.5 && formatDiem < 5){
    Console.WriteLine("Yeu");
} 
else {
    Console.WriteLine("Qua Kem");
}

// nhap so co 3 chu so va tinh tong 3 chu so do 

string? number = Console.ReadLine();
int formatNumber = Convert.ToInt32(number);
if ( formatNumber >= 100 &&  formatNumber < 1000)
{
int hundreds = formatNumber / 100;
int tens = (formatNumber % 100) / 10;
int unit = formatNumber % 10;

int sum = unit + tens + hundreds;
Console.WriteLine($"Tong cac chu so co 3 so la: {sum}");
}
else
{
    Console.WriteLine("Day khong phai la so co 3 chu so");

}
#endregion
#region switch-case 
// C1: Dung switch case 
// Nhap so co trong khoang tu 1 den 10. Doc so 
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
switch(formatNumber2){
    case 1:
    Console.WriteLine("So 1");
    break;

    case 2:
    Console.WriteLine("So 2");
    break;

    case 3:
    Console.WriteLine("So 3");
    break;

    case 4:
    Console.WriteLine("So 4");
    break;

    case 5:
    Console.WriteLine("So 5");
    break;
    
    case 6:
    Console.WriteLine("So 6");
    break;

    case 7:
    Console.WriteLine("So 7");
    break;

    case 8:
    Console.WriteLine("So 8");
    break;

    case 9: 
    Console.WriteLine("So 9");
    break;

    case 10:
    Console.WriteLine("So 10"); 
    break;

    default:
    Console.WriteLine("Hay nhap so tu 1 den 10");
    break;
}



// C2: Dung switch expression

#endregion