using System.Data;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region function trong List cua Collection

        // khoi tao danh sach
        List<int> numbers = new List<int>();    
        // nhap n tu ban phim voi n la so luong phan tu cua mang    
        Console.WriteLine("Moi ban nhap so phan tu cua mang: ");
        string? n = Console.ReadLine();
        int formatNumbers = Convert.ToInt32(n);
        for (int i = 0; i < formatNumbers; i++){
            Console.WriteLine($"Moi ban nhap vao so thu {i + 1}");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);

        }


        Console.WriteLine("Danh sach cac phan tu da nhap la: ");
        // foreach (int number in numbers) {
        //     // Console.WriteLine(number);
        //     Console.Write(number);
        //     Console.Write(",");
        // }
        Console.WriteLine();
        // C1 dung Jion()
        Console.Write(String.Join(", ", numbers)) ;


        // // Dung function Sort de sap xep phan tu cua mang 
        // numbers.Sort();
        // Console.WriteLine("Danh sach phan tu da sap xep: ") ;
        // Console.WriteLine(String.Join(", ", numbers));


        // // Dung function Reverse()
        // numbers.Reverse();
        // Console.WriteLine("") ;
        // Console.WriteLine("Danh sach cac phan tu sau khi dung ham Reverse(): ");
        // Console.Write(String.Join(",", numbers));




    
        #endregion

        #region Bai 1: Tinh tong cac so lon hon 50 trong mang 


        // Khai bao list phan tu 
        // List<int> numbers = new List<int> {20 , 81 , 97 , 63, 72 , 11, 20, 15, 33, 15, 41, 20};
        // int sum = Bai1.tinhTongSoLon50(numbers);
        // Console.WriteLine($"Tong cac so lon hon 50 trong mang la: {sum}" );


        

        #endregion

        #region Bai 2: Tim so lon nhat trong mang

        // giai thuat
        // B1: lay 1 so bat ki trong mang lam so lon nhat ( so dau tien cua mang)
        // B2: duyet mang tu phan tu thu 2 va so sanh voi so dai dien 
        // B3: neu so dai dien nho hon phan tu dang xet => gan lai 
        // B4: nguoc lai => duyet tiep
        //  List<int> numbers = new List<int> {20 , 81 , 97 , 63, 72 , 11, 20, 15, 33, 15, 41, 20};
        //  int max = Bai2.findMaxNumber(numbers);
        //  Console.WriteLine($"So lon nhat trong mang la: {max}");



        #endregion

        #region Bai 3: Tim tat cac nhung chuoi bat dau bang chu m 
        // List<string> lstString =  new List<string> {"apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"};
        // List<string> results = Bai3.findAllStartM(lstString);
        // Console.WriteLine($"Danh sach cac chuoi bat dau bang chu m la:");
        // foreach (string str in Bai3.findAllStartM(results)){
        //         Console.WriteLine(str);
        // }


        #endregion

        #region Bai 4: Liet ke nhung phan tu khong trung nhau
        // List<int> lstNumber = new List<int>{1, 2, 2, 2, 3, 4, 5, 6, 6};
        // List<int> lstResult = Bai4.unquieNumbers(lstNumber);
        // Console.WriteLine($"Danh sach cac phan tu khong trung nhau la: ");
        // foreach (int result in lstResult){
        //     Console.WriteLine(result);
        // }

        #endregion

        #region Tim hieu ve Dictionary trong Collection
        Dictionary<string, string> dic = new Dictionary<string, string>();

        // Thêm key-value vào dic 
        dic.Add("Alice", "test");
        dic["Do"]
        #endregion
    }
}