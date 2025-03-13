class TicketManager{
    private List<Ticket> tickets = new List<Ticket>();

    private static int ticketCount = 1;
    public Ticket createTicket(Movie movie, Customer customet, double price) {
        string ticketID = "T" + ticketCount;
        ticketCount++;

        Ticket ticket = new Ticket(ticketID, movie, customet, price);
        tickets.Add(ticket);
        return ticket;
    }

    public void displayTickets(){
        Console.WriteLine("Tickets: ");
        foreach (Ticket ticket in tickets) {
            ticket.displayTicket();
        }
    }

}