using System;
using System.Collections.Generic;
using System.Linq;

public class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    // Thêm sản phẩm mới
    public void ThemSanPham(SanPham sp)
    {
        danhSachSanPham.Add(sp);
    }

    // Tìm kiếm sản phẩm theo tên
    public SanPham TimKiemSanPham(string ten)
    {
        return danhSachSanPham.FirstOrDefault(sp => sp.TenSanPham.Contains(ten, StringComparison.OrdinalIgnoreCase));
    }

    // Cập nhật giá bán hoặc số lượng tồn kho
    public bool CapNhatSanPham(string maSanPham, double giaBan, int soLuongTon)
    {
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSanPham);
        if (sp != null)
        {
            sp.GiaBan = giaBan;
            sp.SoLuongTonKho = soLuongTon;
            return true;
        }
        return false;
    }

    // Xóa sản phẩm
    public bool XoaSanPham(string maSanPham)
    {
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSanPham);
        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
            return true;
        }
        return false;
    }

    // Hiển thị danh sách sản phẩm và giá trị kho
    public void HienThiDanhSach()
    {
        foreach (var sp in danhSachSanPham)
        {
            Console.WriteLine($"Mã: {sp.MaSanPham}, Tên: {sp.TenSanPham}, Giá: {sp.GiaBan:F2}, Tồn kho: {sp.SoLuongTonKho}, Giá trị kho: {sp.TinhGiaTriKho():F2}");
        }
    }

    // Sắp xếp theo giá bán tăng dần
    public void SapXepTheoGiaBan()
    {
        var danhSachSapXep = danhSachSanPham.OrderBy(sp => sp.GiaBan).ToList();
        foreach (var sp in danhSachSapXep)
        {
            Console.WriteLine($"Mã: {sp.MaSanPham}, Tên: {sp.TenSanPham}, Giá: {sp.GiaBan:F2}");
        }
    }

    // Sắp xếp theo tên sản phẩm (dựa trên từ cuối)
    public void SapXepTheoTen()
    {
        var danhSachSapXep = danhSachSanPham.OrderBy(sp => sp.TenSanPham.Split(' ').Last()).ToList();
        foreach (var sp in danhSachSapXep)
        {
            Console.WriteLine($"Mã: {sp.MaSanPham}, Tên: {sp.TenSanPham}");
        }
    }

    // Đọc dữ liệu từ file JSON
    public void DocDuLieuTuFileJson(string filePath)
    {
        if (System.IO.File.Exists(filePath))
        {
            var jsonData = System.IO.File.ReadAllText(filePath);
            danhSachSanPham = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SanPham>>(jsonData);
        }
    }

    // Ghi dữ liệu ra file JSON
    public void GhiDuLieuRaFileJson(string filePath)
    {
        var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(danhSachSanPham, Newtonsoft.Json.Formatting.Indented);
        System.IO.File.WriteAllText(filePath, jsonData);
    }
}
