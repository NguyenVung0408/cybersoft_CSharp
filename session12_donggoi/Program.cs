using System.Collections.Generic;
internal partial class Program
{
    private static void Main(string[] args)
    {
        #region Lý thuyết tính đóng gói trong OOP
        // Console.WriteLine("Hello, World!");
        // // Tính đóng gói trong OOP
        // // Giới hạn phạm vi truy cập của các thuộc tính trong class 
        // // Nhằm bảo vệ dữ liệu của class
        // // => các thuộc tính trong class nên được khai báo là private
        // // Để truy cập các thuộc tính, ta sử dụng phương thức getter và setter



        // // Tạo đối tượng Person
        // // Dùng try..catch để bắt lỗi nếu có lỗi xảy ra 
        // try{
        //     Person person = new Person();
        //     person.Name = "Nguyen Van A"; // đi qua setter của Name
        //     Console.WriteLine(person.Name); // đi qua getter của Name 

        //     // person.Name = "A"; // lỗi vì tên không hợp lệ 
        //     Console.WriteLine("=================");
        //     Person person1= new Person("Nguyen Van A", 22);
            

        // } catch(ArgumentException ex){
        //     Console.WriteLine(ex.Message);
        // }
        #endregion
        
        
        // Bài tập:
        // 1. Tạo class cha Vehicle
        // - vehicleId: mã phương tiện
        // - brand: hãng xe
        // - year: năm sản xuất
        // - price: giá xe
        // 1.1 Tạo class Car kế thừa từ Vehicle
        // - model: dòng xe
        // - color: màu xe
        // - engine: dung tích động cơ
        // 1.2 Tạo class Motor kế thừa từ Vehicle
        // - type: loại xe (số tay, số tự động)
        // - power: công suất
        // Tạo class VehicleManager để quản lý phương tiện giao thông
        // - danh sách phương tiện
        // - file json lưu thông tin phương tiện (nâng cao)
        // 3. Yêu cầu chức năng
        // - Thêm phương tiện vào danh sách
        // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
        // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
        // - Hiển thị danh sách phương tiện
        // - Tìm phương tiện theo mã phương tiện
        // - Thoát


        // Tạo đối tượng VehicleManager
        VehicleManager vehicleManager= new VehicleManager();
        bool isRunning = true;
        while(isRunning){
            Console.WriteLine("1. Thêm phương tiện xe hơi");
            Console.WriteLine("2. Thêm phương tiện xe máy");
            Console.WriteLine("4. Hiện thị danh sách phương tiện");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Chọn chức năng (1-4) ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                vehicleManager.addCar();
                break;
                case 2:
                vehicleManager.addMotocycle();
                break;
                case 3:
                vehicleManager.displayAllVehicle();
                break;
                case 4:
                isRunning = false;
                break;
                default:
                Console.WriteLine("Chức năng không hợp lệ");
                break;
            }
        }
    }
}