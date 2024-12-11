using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

public class QuanLyHocSinh
{
    private List<HocSinh> danhSachHocSinh = new List<HocSinh>();

    // Thêm học sinh
    public void ThemHocSinh(HocSinh hs)
    {
        danhSachHocSinh.Add(hs);
    }

    // Tìm kiếm học sinh theo tên
    public HocSinh TimKiemHocSinh(string ten)
    {
        return danhSachHocSinh.FirstOrDefault(hs => hs.TenHocSinh.Contains(ten, StringComparison.OrdinalIgnoreCase));
    }

    // Cập nhật điểm số
    public bool CapNhatDiem(string maHocSinh, double diemToan, double diemVan, double diemAnh)
    {
        var hs = danhSachHocSinh.FirstOrDefault(h => h.MaHocSinh == maHocSinh);
        if (hs != null)
        {
            hs.DiemToan = diemToan;
            hs.DiemVan = diemVan;
            hs.DiemAnh = diemAnh;
            return true;
        }
        return false;
    }

    // Xóa học sinh
    public bool XoaHocSinh(string maHocSinh)
    {
        var hs = danhSachHocSinh.FirstOrDefault(h => h.MaHocSinh == maHocSinh);
        if (hs != null)
        {
            danhSachHocSinh.Remove(hs);
            return true;
        }
        return false;
    }

    // Hiển thị danh sách học sinh kèm xếp loại
    public void HienThiDanhSach()
    {
        foreach (var hs in danhSachHocSinh)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, ĐTB: {hs.TinhDiemTrungBinh():F2}, Xếp loại: {hs.XepLoai()}");
        }
    }
    // Sắp xếp học sinh theo điểm trung bình tăng dần
    public void SapXepTheoDiemTB()
    {
        var danhSachSapXep = danhSachHocSinh.OrderBy(hs => hs.TinhDiemTrungBinh()).ToList();
        foreach (var hs in danhSachSapXep)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.TinhDiemTrungBinh():F2}");
        }
    }

    // Lưu dữ liệu ra file JSON
    public void GhiDuLieuRaFileJson(string filePath)
    {
        var jsonData = JsonConvert.SerializeObject(danhSachHocSinh, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }

    // Đọc dữ liệu từ file JSON
    public void DocDuLieuTuFileJson(string filePath)
    {
        if (File.Exists(filePath))
        {
            var jsonData = File.ReadAllText(filePath);
            danhSachHocSinh = JsonConvert.DeserializeObject<List<HocSinh>>(jsonData);
        }
        else
        {
            Console.WriteLine("File không tồn tại!");
        }
    }
}
