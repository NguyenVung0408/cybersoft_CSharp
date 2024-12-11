public class HocSinh
{
    public string MaHocSinh;
    public string TenHocSinh;
    public double DiemToan;
    public double DiemVan;
    public double DiemAnh;

    public double TinhDiemTrungBinh()
    {
        return (DiemToan + DiemVan + DiemAnh) / 3.0;
    }

    public string XepLoai()
    {
        double dtb = TinhDiemTrungBinh();
        if (dtb < 5) return "Yếu";
        if (dtb < 6.5) return "Trung Bình";
        if (dtb < 8) return "Khá";
        return "Giỏi";
    }
}
