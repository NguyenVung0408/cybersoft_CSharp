internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<string> lichSuGiaoDich = new List<string>();
        IThanhToan thanhToan;
        while (true)
        {
            Console.WriteLine("Chọn phương thức thanh toán:");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán online");
            Console.WriteLine("3. Thanh toán bằng thẻ");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    thanhToan = new ThanhToanTienMat();
                    Console.Write("Nhập số tiền cần thanh toán: ");
                    double soTienMat = double.Parse(Console.ReadLine());
                    if (thanhToan.ThanhToan(soTienMat))
                        lichSuGiaoDich.Add($"Thanh toán tiền mặt: {soTienMat} VND.");
                    break;

                case "2":
                    thanhToan = new ThanhToanOnline();
                    Console.Write("Nhập số tiền cần thanh toán: ");
                    double soTienOnline = double.Parse(Console.ReadLine());
                    if (thanhToan.ThanhToan(soTienOnline))
                        lichSuGiaoDich.Add($"Thanh toán online: {soTienOnline} VND.");
                    break;

                case "3":
                    thanhToan = new ThanhToanBangThe();
                    Console.Write("Nhập số tiền cần thanh toán: ");
                    double soTienThe = double.Parse(Console.ReadLine());
                    if (thanhToan.ThanhToan(soTienThe))
                        lichSuGiaoDich.Add($"Thanh toán bằng thẻ: {soTienThe} VND.");
                    break;

                case "4":
                    Console.WriteLine("Lịch sử giao dịch:");
                    foreach (var giaoDich in lichSuGiaoDich)
                        Console.WriteLine(giaoDich);
                    break;

                case "5":
                    Console.WriteLine("Thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
            Console.WriteLine();
        }
    }
}