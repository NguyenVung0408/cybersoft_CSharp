internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // bản chất của OOP đó chính là gom nhóm các biến
        // các biến được gọi là các thuộc tính 
        // Lưu ý: chữ cái đầu tiên trong tên class phải là in hoa 
        BaiViet baiviet1 = new BaiViet(); // vùng nhớ: x123
        baiviet1.tieuDe = "";
        baiviet1.hinhAnh = "";
        baiviet1.noiDung = "";
        // Console.WriteLine($"bai viet 1: {baiviet1.tieuDe}, {baiviet1.hinhAnh}, {baiviet1.noiDung}");
        baiviet1.xuatThongTin();


        BaiViet baiviet2 = new BaiViet();
        baiviet2.tieuDe = "";
        baiviet2.hinhAnh = "";
        baiviet2.noiDung = "";
        baiviet2.xuatThongTin();

        BaiViet baiviet3;
        baiviet3 = baiviet1;
        Console.WriteLine($"kiem tra: {baiviet3 == baiviet1}");
        baiviet3.hinhAnh = "hinh3.png";
        Console.WriteLine(baiviet1.hinhAnh);

        BaiViet baiviet4 = new BaiViet(); // cấp vùng nhớ mới: x234
        baiviet4.hinhAnh= baiviet1.hinhAnh;
        baiviet4.noiDung = baiviet1.noiDung;
        baiviet4.tieuDe = baiviet1.tieuDe;
        Console.WriteLine($"Kiem tra: {baiviet4 == baiviet1}");

        // Bai tap nhap mon
        // tạo đối tượng học sinh(họ tên, tuổi, giới tính, email)
        // xuất thông tin học sinh 
        
    }
}