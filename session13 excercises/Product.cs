public class SanPham
{
    public string MaSanPham;
    public string TenSanPham;
    public double GiaBan;
    public int SoLuongTonKho;

    public double TinhGiaTriKho()
    {
        return GiaBan * SoLuongTonKho;
    }
}
