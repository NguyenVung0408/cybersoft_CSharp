public class ThoiTrang : SanPham
{
    public ThoiTrang(string maSanPham, string tenSanPham, double giaGoc) 
        : base(maSanPham, tenSanPham, giaGoc) { }

    public override double TinhGiaBan()
    {
        return giaGoc * 0.9; // Áp dụng giảm giá 10%
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan()} VND (đã áp dụng giảm giá)");
    }
}
