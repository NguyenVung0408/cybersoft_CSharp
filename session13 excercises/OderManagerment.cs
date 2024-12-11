public class QuanLyDonHang
{
    private List<DonHang> danhSachDonHang = new List<DonHang>();
    private QuanLySanPham quanLySanPham;

    public QuanLyDonHang(QuanLySanPham qlsp)
    {
        quanLySanPham = qlsp;
    }

    // Thêm đơn hàng
    public void ThemDonHang(DonHang dh)
    {
        var sp = quanLySanPham.TimKiemSanPham(dh.MaSanPham);
        if (sp != null && sp.SoLuongTonKho >= dh.SoLuongBan)
        {
            danhSachDonHang.Add(dh);
            sp.SoLuongTonKho -= dh.SoLuongBan;
        }
        else
        {
            Console.WriteLine("Không đủ số lượng tồn kho hoặc sản phẩm không tồn tại.");
        }
    }

    // Hiển thị danh sách đơn hàng
    public void HienThiDanhSachDonHang()
    {
        foreach (var dh in danhSachDonHang)
        {
            Console.WriteLine($"Mã ĐH: {dh.MaDonHang}, Mã SP: {dh.MaSanPham}, Số lượng: {dh.SoLuongBan}, Người đặt: {dh.TenNguoiDat}, Đã giao: {dh.DaGiao}");
        }
    }

    // Cập nhật trạng thái giao hàng
    public bool CapNhatTrangThaiDonHang(string maDonHang, bool daGiao)
    {
        var dh = danhSachDonHang.FirstOrDefault(d => d.MaDonHang == maDonHang);
        if (dh != null)
        {
            dh.DaGiao = daGiao;
            return true;
        }
        return false;
    }
}
