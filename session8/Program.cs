internal partial class Program{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> lst = new List<int>{2, 7, 11, 15};
        int target = 26;
        Console.WriteLine("Bai 1: Tim 2 chi so co tong cua 2 so bang voi target: ");
        if(TwoSum.twoSum(lst, target) == null){
            Console.WriteLine("Khong co tong hai so nao bang target");
        } else {
            List<int> indexes = TwoSum.twoSum(lst, target);
            Console.WriteLine($"Chi so 2 so co tong bang bang target la: {string.Join(',', indexes)} ");
        }
        Console.WriteLine("C2: Dùng Dictionary");
        if (TwoSum.twoSumDictionary(lst, target) == null){
            Console.WriteLine("Không có 2 số nào có tổng bằng target");
        } else {
            Console.WriteLine($"Chỉ số 2 số có tổng bằng target là: {}")
        }
    

    }
}