namespace PMPML_TicketGhar.Models

{
    public class GuestTicket
    {
        public int GuestTicketId { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public int BusId { get; set; }
        public string TicketType { get; set; }
        public decimal Fare { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Bus Bus { get; set; }
    }
}
