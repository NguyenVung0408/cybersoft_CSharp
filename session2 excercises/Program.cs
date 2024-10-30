// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Tính số ngày trong tuần và ngày số lẻ 
Console.Write("Mời bạn nhập số ngày: ");
        string? soNgay = Console.ReadLine();
        int formatSoNgay = Convert.ToInt32(soNgay); 
        
        int soTuan = formatSoNgay / 7;
        int soNgayLe = formatSoNgay % 7;

        Console.WriteLine($"Số tuần: {soTuan}, Số ngày lẻ: {soNgayLe}");
#endregion
#region 
Console.Write("Nhập giá trị đơn hàng: ");
        double total = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhập phần trăm giảm giá: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discountAmount = total * (discountPercent / 100);
        double finalAmount = total - discountAmount;

        Console.WriteLine($"Số tiền giảm giá: {discountAmount}");
        Console.WriteLine($"Tổng số tiền sau khi giảm giá: {finalAmount}");
#endregion
#region 
Console.Write("Mời bạn nhập số phút: ");
        string? soPhut = Console.ReadLine();
        int minutes = Convert.ToInt32(soPhut);


        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;

        Console.WriteLine($"{hours} giờ {remainingMinutes} phút");
#endregion
#region 
Console.Write("Mời bạn nhập số tiền gốc: ");
        double originalAmount = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhập tỷ lệ thuế VAT (%): ");
        double vatRate = Convert.ToDouble(Console.ReadLine());

        double vatAmount = originalAmount * (vatRate / 100);
        double totalAmount = originalAmount + vatAmount;

        Console.WriteLine($"Tổng số tiền sau khi cộng thuế VAT: {totalAmount}");
#endregion
#region 
Console.Write("Mời bạn nhập số tiền USD: ");
        double usdAmount = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhập tỷ giá USD sang VND: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());

        double vndAmount = usdAmount * exchangeRate;

        Console.WriteLine($"Số tiền tương ứng bằng VND: {vndAmount}");
#endregion