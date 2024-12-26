using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<SanPham> danhSachSanPham = new List<SanPham>();

        while (true)
        {
            Console.WriteLine("1. Thêm sản phẩm vào danh sách");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm khỏi danh sách theo mã");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    ThemSanPham(danhSachSanPham);
                    break;

                case "2":
                    HienThiDanhSachSanPham(danhSachSanPham);
                    break;

                case "3":
                    TinhTongDoanhThu(danhSachSanPham);
                    break;

                case "4":
                    XoaSanPham(danhSachSanPham);
                    break;

                case "5":
                    Console.WriteLine("Thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void ThemSanPham(List<SanPham> danhSachSanPham)
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        Console.Write("Lựa chọn: ");
        string loaiSanPham = Console.ReadLine();

        Console.Write("Nhập mã sản phẩm: ");
        string maSanPham = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string tenSanPham = Console.ReadLine();
        Console.Write("Nhập giá gốc: ");
        double giaGoc = double.Parse(Console.ReadLine());

        switch (loaiSanPham)
        {
            case "1":
                danhSachSanPham.Add(new DienTu(maSanPham, tenSanPham, giaGoc));
                break;

            case "2":
                danhSachSanPham.Add(new ThoiTrang(maSanPham, tenSanPham, giaGoc));
                break;

            case "3":
                danhSachSanPham.Add(new ThucPham(maSanPham, tenSanPham, giaGoc));
                break;

            default:
                Console.WriteLine("Loại sản phẩm không hợp lệ.");
                break;
        }
    }

    static void HienThiDanhSachSanPham(List<SanPham> danhSachSanPham)
    {
        Console.WriteLine("Danh sách sản phẩm:");
        foreach (var sp in danhSachSanPham)
        {
            sp.HienThiThongTin();
        }
    }

    static void TinhTongDoanhThu(List<SanPham> danhSachSanPham)
    {
        double tongDoanhThu = 0;
        foreach (var sp in danhSachSanPham)
        {
            tongDoanhThu += sp.TinhGiaBan();
        }
        Console.WriteLine($"Tổng doanh thu dự kiến: {tongDoanhThu} VND.");
    }

    static void XoaSanPham(List<SanPham> danhSachSanPham)
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string maSanPham = Console.ReadLine();

        var sp = danhSachSanPham.Find(x => x.maSanPham == maSanPham);
        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
            Console.WriteLine("Xóa sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm với mã đã nhập.");
        }
    }
}
