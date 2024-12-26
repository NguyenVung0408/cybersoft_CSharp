public class ThanhToanOnline : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã PIN để xác nhận giao dịch: ");
        string pin = Console.ReadLine();

        if (pin == "1234")
        {
            Console.WriteLine($"Thanh toán online thành công: {soTien} VND.");
            return true;
        }
        else
        {
            Console.WriteLine("Mã PIN không đúng. Giao dịch thất bại.");
            return false;
        }
    }
}
