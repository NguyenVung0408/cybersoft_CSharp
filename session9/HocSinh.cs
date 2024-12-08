class HocSinh{
    public string hoTen;
    public int tuoi;
    public string gioiTinh;
    public string email;

    public void xuatThongTin(){
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"{tuoi} tuoi");
        Console.WriteLine($"{gioiTinh}");
        Console.WriteLine($"{email}");

    }
}