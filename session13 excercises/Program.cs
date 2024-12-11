class Program
{
    static void Main(string[] args)
    {
        #region Quản lý học sinh 
        // QuanLyHocSinh qlhs = new QuanLyHocSinh();
        // string filePath = "danhSachHocSinh.json";

        // while (true)
        // {
        //     Console.WriteLine("\nChọn chức năng:");
        //     Console.WriteLine("1. Thêm học sinh");
        //     Console.WriteLine("2. Tìm kiếm học sinh");
        //     Console.WriteLine("3. Cập nhật điểm học sinh");
        //     Console.WriteLine("4. Xóa học sinh");
        //     Console.WriteLine("5. Hiển thị danh sách học sinh");
        //     Console.WriteLine("6. Sắp xếp học sinh theo điểm TB");
        //     Console.WriteLine("7. Ghi dữ liệu ra file JSON");
        //     Console.WriteLine("8. Đọc dữ liệu từ file JSON");
        //     Console.WriteLine("9. Thoát");

        //     int choice = int.Parse(Console.ReadLine());
        //     switch (choice)
        //     {
        //         case 1:
        //             Console.Write("Nhập mã học sinh: ");
        //             string maHS = Console.ReadLine();
        //             Console.Write("Nhập tên học sinh: ");
        //             string tenHS = Console.ReadLine();
        //             Console.Write("Nhập điểm Toán: ");
        //             double diemToan = double.Parse(Console.ReadLine());
        //             Console.Write("Nhập điểm Văn: ");
        //             double diemVan = double.Parse(Console.ReadLine());
        //             Console.Write("Nhập điểm Anh: ");
        //             double diemAnh = double.Parse(Console.ReadLine());
        //             qlhs.ThemHocSinh(new HocSinh { MaHocSinh = maHS, TenHocSinh = tenHS, DiemToan = diemToan, DiemVan = diemVan, DiemAnh = diemAnh });
        //             break;
        //         case 2:
        //             Console.Write("Nhập tên học sinh cần tìm: ");
        //             string tenTimKiem = Console.ReadLine();
        //             var hsTimKiem = qlhs.TimKiemHocSinh(tenTimKiem);
        //             if (hsTimKiem != null)
        //             {
        //                 Console.WriteLine($"Mã: {hsTimKiem.MaHocSinh}, Tên: {hsTimKiem.TenHocSinh}, ĐTB: {hsTimKiem.TinhDiemTrungBinh():F2}, Xếp loại: {hsTimKiem.XepLoai()}");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Không tìm thấy học sinh.");
        //             }
        //             break;
        //         case 3:
        //             Console.Write("Nhập mã học sinh cần cập nhật: ");
        //             string maCapNhat = Console.ReadLine();
        //             Console.Write("Nhập điểm Toán mới: ");
        //             double diemToanMoi = double.Parse(Console.ReadLine());
        //             Console.Write("Nhập điểm Văn mới: ");
        //             double diemVanMoi = double.Parse(Console.ReadLine());
        //             Console.Write("Nhập điểm Anh mới: ");
        //             double diemAnhMoi = double.Parse(Console.ReadLine());
        //             if (qlhs.CapNhatDiem(maCapNhat, diemToanMoi, diemVanMoi, diemAnhMoi))
        //             {
        //                 Console.WriteLine("Cập nhật thành công.");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Không tìm thấy học sinh.");
        //             }
        //             break;
        //         case 4:
        //             Console.Write("Nhập mã học sinh cần xóa: ");
        //             string maXoa = Console.ReadLine();
        //             if (qlhs.XoaHocSinh(maXoa))
        //             {
        //                 Console.WriteLine("Xóa thành công.");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Không tìm thấy học sinh.");
        //             }
        //             break;
        //         case 5:
        //             qlhs.HienThiDanhSach();
        //             break;
        //         case 6:
        //             qlhs.SapXepTheoDiemTB();
        //             break;
        //         case 7:
        //             qlhs.GhiDuLieuRaFileJson(filePath);
        //             Console.WriteLine("Dữ liệu đã được ghi vào file JSON.");
        //             break;
        //         case 8:
        //             qlhs.DocDuLieuTuFileJson(filePath);
        //             Console.WriteLine("Dữ liệu đã được đọc từ file JSON.");
        //             break;
        //         case 9:
        //             return;
                
        //     }
        // }
        #endregion
        #region Quản lý sản phẩm - đơn hàng
        QuanLySanPham qlsp = new QuanLySanPham();
        QuanLyDonHang qldh = new QuanLyDonHang(qlsp);

        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Tìm kiếm sản phẩm");
            Console.WriteLine("3. Cập nhật sản phẩm");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Hiển thị danh sách sản phẩm");
            Console.WriteLine("6. Sắp xếp theo giá bán");
            Console.WriteLine("7. Sắp xếp theo tên sản phẩm");
            Console.WriteLine("8. Thêm đơn hàng");
            Console.WriteLine("9. Hiển thị danh sách đơn hàng");
            Console.WriteLine("10. Cập nhật trạng thái đơn hàng");
            Console.WriteLine("11. Thoát");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Nhập mã sản phẩm: ");
                    string maSP = Console.ReadLine();
                    Console.Write("Nhập tên sản phẩm: ");
                    string tenSP = Console.ReadLine();
                    Console.Write("Nhập giá bán: ");
                    double giaBan = double.Parse(Console.ReadLine());
                    Console.Write("Nhập số lượng tồn kho: ");
                    int soLuongTon = int.Parse(Console.ReadLine());
                    qlsp.ThemSanPham(new SanPham { MaSanPham = maSP, TenSanPham = tenSP, GiaBan = giaBan, SoLuongTonKho = soLuongTon });
                    break;
                case 8:
                    Console.Write("Nhập mã đơn hàng: ");
                    string maDH = Console.ReadLine();
                    Console.Write("Nhập mã sản phẩm: ");
                    string maSPDH = Console.ReadLine();
                    Console.Write("Nhập số lượng bán: ");
                    int soLuongBan = int.Parse(Console.ReadLine());
                    Console.Write("Nhập tên người đặt: ");
                    string nguoiDat = Console.ReadLine();
                    qldh.ThemDonHang(new DonHang { MaDonHang = maDH, MaSanPham = maSPDH, SoLuongBan = soLuongBan, TenNguoiDat = nguoiDat, DaGiao = false });
                    break;
                case 11:
                    return;
            }
        }
        #endregion
    }
}
