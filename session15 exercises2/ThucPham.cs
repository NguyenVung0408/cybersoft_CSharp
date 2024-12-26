public class ThucPham : SanPham
{
    public ThucPham(string maSanPham, string tenSanPham, double giaGoc) 
        : base(maSanPham, tenSanPham, giaGoc) { }

    public override double TinhGiaBan()
    {
        return giaGoc + 10; // Cộng phí vận chuyển 10 VND
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan()} VND (bao gồm phí vận chuyển)");
    }
}
