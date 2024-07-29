namespace PMPML_TicketGhar.Models

{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int BusId { get; set; }
        public string TicketType { get; set; }
        public decimal Fare { get; set; }
        public DateTime PurchaseDate { get; set; }

        public User User { get; set; }
        public Bus Bus { get; set; }
    }
}
