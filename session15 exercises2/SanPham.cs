public abstract class SanPham
{
    private string MaSanPham;
    public string maSanPham
    {
        get { return MaSanPham; }
        set { MaSanPham = value; }
    }
    private string TenSanPham;
    public string tenSanPham
    {
        get { return TenSanPham; }
        set { TenSanPham = value; }
    }
    private double GiaGoc;
    public double giaGoc
    {
        get { return GiaGoc; }
        set { GiaGoc = value; }
    }

    public SanPham(string maSanPham, string tenSanPham, double giaGoc)
    {
        MaSanPham = maSanPham;
        TenSanPham = tenSanPham;
        GiaGoc = giaGoc;
    }

    // Phương thức trừu tượng để tính giá bán
    public abstract double TinhGiaBan();

    // Phương thức ảo để hiển thị thông tin sản phẩm
    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã: {MaSanPham}, Tên: {TenSanPham}, Giá gốc: {GiaGoc} VND");
    }
}
