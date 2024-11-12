internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Kiem tra so nguyen to     
        // Console.WriteLine("Moi ban nhap so: ");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        // if (Method.checkPrime(formatNumber) == true){
        //     Console.Write($"So {formatNumber} la so nguyen to");
        // } else {
        //     Console.WriteLine($"So {formatNumber} khong phai la so nguyen to");
        // }
        #endregion

        #region In ra tam gia vuong co chieu cao nhap tu ban phim 

        //  Console.WriteLine("Moi ban nhap chieu cao tam giac: ");
        //  int height = Convert.ToInt32(Console.ReadLine());
        //  Method.printSquareTriangle(height);
        #endregion

        #region Collection trong C#
        // data structure
        // List
        List<int> numbers = new List<int>();

        // define gia tri ban dau 
        List<string> names = new List<string>{"Phuong", "Duc", "Linh", "Hung", "Tri"};
        //                             index     1        2       3       4      5
        //                          reverseIndex ^5       ^4      ^3      ^2     ^1
        Console.WriteLine($"Phan tu thu 2 la: {names[2]}");
        Console.WriteLine($"Phan tu thu nghich dao la: {names[^3]}");

        // Console.WriteLine(names);
        // Lưu ý: WriteLine chỉ in được những giá trị có kiểu dữ liệu nguyên thủy như: string, int, float, double,...
        // Còn kiểu dữ liệu Collection thì chỉ in ra địa chỉ vùng nhớ của biến đó
        Console.WriteLine(string.Join(", ", names));


        // Bai tap: nhap n tu ban phim. Sau do nhap n phan tu va xuat ra n phan tu
        Console.WriteLine("Moi ban nhap so luong phan tu: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Tao bien chua danh sach phan tu
        List<int> listNumbers = new List<int>();

        for (int i = 0; i < number; i++){
            //C1: Dung Insert
            Console.WriteLine($"Nhap phan tu thu: {i + 1}");
            int item =  Convert.ToInt32(Console.ReadLine());
            listNumbers.Insert(i, item);

            //C2: Dung add

        }
        // In list phan tu ra ngoai man hinh 
        // Co 2 cach duyet phan tu: for or foreach
        // C1: for
        Console.WriteLine("Danh sach cac phan tu da nhap la: ");
        for (int i = 0; i < listNumbers.Count; i++){
            Console.WriteLine(listNumbers[i]);
        }

        // C2: foreach
        Console.WriteLine("Danh sach phan tu dung foreach: ");
        foreach (int item in listNumbers){
            Console.WriteLine(item);
        }
        #endregion
    }
}