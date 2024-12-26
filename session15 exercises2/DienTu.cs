public class DienTu : SanPham
{
    public DienTu(string maSanPham, string tenSanPham, double giaGoc) 
        : base(maSanPham, tenSanPham, giaGoc) { }

    public override double TinhGiaBan()
    {
        return giaGoc + giaGoc * 0.1; // Thêm thuế bảo hành 10%
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan()} VND (bao gồm thuế bảo hành)");
    }
}
