public class ThanhToanTienMat : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toán tiền mặt: {soTien} VND.");
        return true; // Luôn thành công vì không cần xác nhận thêm
    }
}
