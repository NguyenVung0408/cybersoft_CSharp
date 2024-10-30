        // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Hoc phep toan co ban
// int add = 5 + 10;
// Console.WriteLine($"Ket qua cong 2 so 5 va 10 la: {add}");

// int minus = 1231231 - 34546;
// Console.WriteLine($"Ket qua tru hai so 1231231 va 34546 la: {minus}");

// double devide = 5/2;
// Console.WriteLine($"Ket qua chia lay phan nguyen cua 2 so 5 va 2 la: {devide}");

#endregion
#region numberic toan tu
// int cong = 0;
// cong += 10;
// Console.WriteLine($"Numberic toan tu cong: {cong}"); 

// int nhan = 1;
// nhan *=100;
// Console.WriteLine($"Numeric toan tu nhan: {nhan}");
#endregion
#region Ep kieu du lieu
// Convert
// Console.WriteLine("Moi ban hap vao so: ");
// string? number = Console.ReadLine();

// int convertNumber = Convert.ToInt32(number); 
// int sum = convertNumber + 1;  
// Console.WriteLine($"value number: {sum}");  
#endregion
#region Tinh chi so BMI 
//INPUT
//Chieu cao va can nang nhap tu ban phim 
// Console.WriteLine("Moi ban nhap chieu cao (m): ");
// string? chieuCao = Console.ReadLine();
// double formatChieuCao = Convert.ToDouble(chieuCao);

// Console.WriteLine("Moi ban nhap can nag (kg)" );
// string? canNang = Console.ReadLine();  
// double formatCanNang = Convert.ToDouble(canNang);
// //OUPUT
// //In ra chi so BMI
// double bmi = 0.0;


// //PROCESS
// //bmi = can nang / (chieu cao )*(chieu cao )
// bmi = formatCanNang/(formatChieuCao)*(formatChieuCao);
// Console.WriteLine("Chi so BMI cua ban la: {bmi}");

#endregion
#region Tinh chu vi va Dien tich hinh tron
//INPUT
Console.WriteLine("Moi ban nhap ban kinh hinh tron: ");
string? banKinh = Console.ReadLine();
double formatBanKinh = Convert.ToDouble(banKinh);

//OUTPUT
double chuVi = 0.0;
double dienTich = 0.0;


// PROCESS
double PI = Math.PI;
chuVi= 2*PI*formatBanKinh;
dienTich= PI*formatBanKinh*formatBanKinh;
Console.WriteLine($"Chu vi hinh tron la: {chuVi}");
Console.WriteLine($"Dien tich hinh tron la: {dienTich}");
#endregion