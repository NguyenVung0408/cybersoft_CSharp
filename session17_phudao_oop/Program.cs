internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Cinema cinema = new Cinema();

        Movie movie1 = new Movie("M1", "The Avengers", "Joss Whedon", 120, 10);
        Movie movie2 = new Movie("M2", "The Avengers: Age of Ultron", "Joss Whedon", 130, 10);
        Movie movie3 = new Movie("M3", "The Avengers: Infinity War", "Anthony Russo", 140, 10);
        cinema.addMovie(movie1);
        cinema.addMovie(movie2);
        cinema.addMovie(movie3);

        // Main menu
        int choice;
        bool isRunning = true;
        while (isRunning){
            Console.WriteLine("===== Main Menu =====");
            Console.WriteLine("1. Add a new customer");
            Console.WriteLine("2. Book a ticket");
            Console.WriteLine("3.View user's ticket");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("Enter customer's name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter customer's email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter customer's phone number: ");
                    string phoneNumber = Console.ReadLine();
                    Customer customer = new Customer(name, email, phoneNumber);
                    cinema.addCustomer(customer);
                    break;
                case 2:
                    Console.WriteLine("Enter customer email: ");
                    string email2 = Console.ReadLine();
                    Customer customer1 = cinema.Customers.Find(c => c.Email == email2);
                    if (customer1 == null){
                        Console.WriteLine("Customer not found!");
                        break;
                    }
                    Console.WriteLine("Enter movie ID: ");
                    string movieId = Console.ReadLine();
                    Movie movie = cinema.Movies.Find(m => m.MovieID == movieId);
                    if (movie == null){
                        Console.WriteLine("Movie not found!");
                        break;
                    }

                    Console.WriteLine("Enter ticket price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    cinema.bookTicket(movie, customer1, price);
                    break;
                case 3:
                    foreach(Customer c in cinema.Customers){
                        c.viewBookingHistory();
                        Console.WriteLine("==================================");
                    }
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }

        }

    }
}