class Cinema {
    private List<Customer> customers = new List<Customer>();

    public List<Customer> Customers {
        get { return customers; }
        set { customers = value; }
    }
    private List<Movie> movies = new List<Movie>();

    public List<Movie> Movies {
        get { return movies; }
        set { movies = value; }
    }
    private TicketManager ticketManager = new TicketManager();

    // Add a new customer to the list
    public void addCustomer(Customer customer){
        customers.Add(customer);
        Console.WriteLine($"Customer added successfully!");
    }

    // Add a new movie to the list 
    public void addMovie(Movie movie){
        movies.Add(movie);
        Console.WriteLine($"Movie added successfully!");
    }

    // Add a new ticket to the customer
    public void bookTicket(Movie movie, Customer customer, double price){
        Ticket ticket = ticketManager.createTicket(movie, customer, price);
        customer.addTicket(ticket);
        Console.WriteLine($"Ticket booker successfully! by {customer.Name}");
    }
}