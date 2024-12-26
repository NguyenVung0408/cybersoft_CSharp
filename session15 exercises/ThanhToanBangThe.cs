public class ThanhToanBangThe : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã OTP để xác nhận giao dịch: ");
        string otp = Console.ReadLine();

        if (otp == "9999")
        {
            Console.WriteLine($"Thanh toán bằng thẻ thành công: {soTien} VND.");
            return true;
        }
        else
        {
            Console.WriteLine("Mã OTP không đúng. Giao dịch thất bại.");
            return false;
        }
    }
}
