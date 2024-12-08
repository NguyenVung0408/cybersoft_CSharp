using System.Runtime.CompilerServices;

class BaiViet{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;

    public void xuatThongTin(){
        Console.WriteLine("Thong tin bai viet la:");
        Console.WriteLine($"Tieu de: {tieuDe}");
        Console.WriteLine($"Noi dung: {noiDung}");
        Console.WriteLine($"Hinh anh: {hinhAnh}");
    }
    
}