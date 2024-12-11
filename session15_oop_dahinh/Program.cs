// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Animal dog = new Dog("Lulu", "Husky");
        dog.Speak();
        dog.displayInfo();
        
        //Dùng class Animal để đại diện cho các class con 
        List<Animal> animals = new List<Animal>();
        
        // Tạo đối tượng Dogg
        Dog dog1 = new Dog("Hehe", "Bulldog");
        // Add đối tượng dog1 vào list animals 
        animals.Add(dog1);
        // Tạo đối tượng Cat 
        Cat cat = new Cat("Meo", "White");
        // Add đối tượng cat vào list animals
        animals.Add(cat);
        
        //In ra list animals
        foreach (var animal in animals)
        {
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("===============");
        }
        
        //Lưu thành animals vào file json 
        //Lưu thêm type object vào file json để khi loadFile có thể biết được object đó của class nào
        string json = JsonConvert.SerializeObject(animals, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        });
        File.WriteAllText("animals.json", json);
        Console.WriteLine("Lưu file thành công");
        
        // Đọc file json 
        string jsonFromFile = File.ReadAllText("animals.json");
        List<Animal>? animals1 = JsonConvert.DeserializeObject<List<Animal>>(jsonFromFile, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
        });
        Console.WriteLine("Đọc file trước khi update");
        foreach (var animal in animals1)
        {
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("===============");
        }
    }
}


