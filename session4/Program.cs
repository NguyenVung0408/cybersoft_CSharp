// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



//while 
//for
//do....while

#region while statement 
// Console.WriteLine("Moi ban nhap so: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// while (count<=formatNumber){
//     Console.WriteLine(count);
//     count++;
// }

// Nhap so n tu ban phim. In ra tong cac so tu 1 -> n 
// S = 1 + 2 + 3 + ...... + n; 
// Console.WriteLine("Moi ban nhap so: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum =   0;
// while (count<= number){
//     sum+= count;
//     count++ ;
// }
// Console.WriteLine($"Tong cac so tu 1 den n la: {sum}");



// Tinh giai thua cua 1 so 
// Console.WriteLine("Moi ban nhap so: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int factorial = 1;
// while (count<=number){
//     factorial *= count;
//     count++ ;
// }
// Console.WriteLine($"giai thua cua so {number} la: {factorial}");



//  kiem tra so n co phai la so nguyen to hay khong 
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// gia su a va b la uoc cua n 
// it nhat 1 trong 2 so a va b phai nho hon can bac 2 cua n 
// vi neu a va b lon hon can bac 2 cua n thi a*b se lon hon n 


// while (count < number ){ //count <= Math.Sqrt(number) (count < can bac 2 cua n)
//     if (number % count == 0 ){
//         Console.WriteLine($"So {number} khong phai la so nguyen to");
//         break;
//     }
//     count++;
// }
// if (count == number){
//     Console.WriteLine($"So {number} la so nguyen to ");
// }


// In bang cuu chuong cua n voi n nhap tu ban phim
// Console.WriteLine("Moi ban nhap so: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int result = 1;
// while (count<=10){
//     result = count * number;
//     Console.WriteLine($"{count} * {number} = {result}");
//     count++ ;
// }


// Kiem tra so nguyen to dung for
// Console.WriteLine("Moi ban nhap so: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (count = 2; count < number; count++){
//     if(number % count == 0){
//         Console.Write($"So {number} khong phai la so nguyen to");
//         break;
//     }
// }
// if (count == number){
//     Console.Write($"So{number} la so nguyen to");
// }

// for long nhau => ma tran ( nhieu mang ket hop voi nhau)

// Console.WriteLine("Moi ban nhap chieu dai: ");
// int chieuDai = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Moi ban nhap chieu rong: ");
// int chieuRong = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < chieuRong; i++){
//     for (int j = 0; j < chieuDai; j++) {
//         Console.Write("*");
//     }
//     Console.Write("\n");
// }


Console.WriteLine("Moi ban nhap chieu cao cua tam giac: ");
int height = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < height; i++){
    for (int j = 0; j <height - i - 1; j++) {
        Console.Write(" ");
    }
    for (int k = 0; k < (2*i+1); k++) {
        Console.Write("*");
    }
    Console.WriteLine();
}

#endregion
