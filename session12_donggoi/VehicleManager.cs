using Newtonsoft.Json;
using System.Collections.Generic;

class VehicleManager{
    private List<Vehicle>  vehicles;

    public List<Vehicle> Vehicles {
        get { return vehicles; }
        set { vehicles = value; }
    }

    private string filePath = "vehicles.json";

    // Viết hàm loadData để đọc dữ liệu từ file json
    // Dùng thư viện Newtonsoft.Json

    private void loadData(){ // Dùng trong contructor
        // Kiểm tra file có tồn tại chưa 
        if(File.Exists(filePath)){
            // Đọc dữ liệu từ file Json
            string json = File.ReadAllText(filePath);

            // Chuyển dữ liệu từ string json sang List<Vehicle>
            Vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(json);
        } else {
            Vehicles = new List<Vehicle>();
        }
    }

    public void saveData(){ // dùng trong hàm addVehicle và removeVehicle
        // Chuyển dữ liệu từ List<Vehicle> sang string json
        string json = JsonConvert.SerializeObject(Vehicles, Formatting.Indented);

        // Lưu dữ liệu vào file Json 
        File.WriteAllText(filePath, json);
    }

    // Contructor
    public VehicleManager() {
        loadData();

    }

    // Viết hàm addVehicle để thêm phương tiện vào danh sách 
    public void addVehicle(Vehicle vehicle){
        // Kiểm tra phươn tiện đã tồn tại chưa  
        Vehicle v = Vehicles.Find(v => v.VehicleId == vehicle.VehicleId);
        if(v != null){
            throw new ArgumentException("Mã phương tiện đã tồn tại ");
        }
        Vehicles.Add(vehicle);
        saveData();
        Console.WriteLine("Thêm phương tiện thành công");
    }

    // Viết hàm addCar để thêm xe vào danh sách
    public void addCar (){
        Console.WriteLine("Nhập mã phương tiện: ");
        string vehicleId = Console.ReadLine();

        Console.WriteLine("Nhập hãng: ");
        string brand = Console.ReadLine();

        Console.WriteLine("Nhập năm sản xuất: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập giá: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập dòng xe: ");
        string model = Console.ReadLine();

        Console.WriteLine("Nhập màu xe: ");
        string color = Console.ReadLine();

        Console.WriteLine("Nhập dung tích động cơ: ");
        int engine = Convert.ToInt32(Console.ReadLine());

        Car car = new Car(vehicleId, brand, year, price, model, color, engine);
        addVehicle(car);

    }

    // Viết hàm addMotocycle để thêm xe vào danh sách
    public void addMotocycle(){
                Console.WriteLine("Nhập mã phương tiện: ");
        string vehicleId = Console.ReadLine();

        Console.WriteLine("Nhập hãng: ");
        string brand = Console.ReadLine();

        Console.WriteLine("Nhập năm sản xuất: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập giá: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập loại xe: ");
        string type = Console.ReadLine();

        Console.WriteLine("Nhập công xuất của xe: ");
        int power = Convert.ToInt32(Console.ReadLine());

        Motocycle motocycle= new Motocycle(vehicleId, brand, year, price, type, power);
        addVehicle(motocycle);
    }

    // Viết hàm displayAllVehicle() để hiện thị danh sách phương tiện

    public void displayAllVehicle(){
        Console.WriteLine("===Danh sách phương tiện===");
        foreach(Vehicle vehicle in Vehicles){
            vehicle.displayInfo();
            Console.WriteLine("-------------------------");
        }
    }

}