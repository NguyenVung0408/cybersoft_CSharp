using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // gọi hàm
        int ketQua = tinhTong(10,11);
        Console.WriteLine($"Tong 2 so la: {ketQua}");



        Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
        Console.WriteLine("Mời bạn nhập số: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int count = 2; count <= number; count++){
            bool checkPrime = isPrime(count);
                

            if(checkPrime == true) {
            Console.Write($"{count} ");
        }
    }
    Console.WriteLine("Moi ban nhap so: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    int originalNumber = number3;
    int reverseNumber = getReverseNumber(number3);


    if (reverseNumber == originalNumber){
        Console.WriteLine($"So {originalNumber} la so doi xung");
    } else{
        Console.WriteLine($"So {originalNumber} khong phai la so doi xung");
    }
}
    // Khai bao ham lay ra so nghich dao

    private static int getReverseNumber (int number){

        int originalNumber = number;
        int reverseNumber = 0;

         while (number > 0){
             int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        return reverseNumber;
    }


    // khai báo hàm kiểm tra số nguyên tố 
    private static bool isPrime( int number ){
        if(number < 2) 
        return false;

        for (int count = 2; count <= Math.Sqrt(number); count++){
            if (number % count == 0){
                return false;
            }
        }
        return true;
    }

    // khai báo hàm
    private static int tinhTong(int number1, int number2){
        return number1 + number2;
    }
}
    
   



