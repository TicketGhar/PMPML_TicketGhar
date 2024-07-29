namespace PMPML_TicketGhar.Models
{
    public class Penalty
    {
        public int PenaltyId { get; set; }
        public int TicketCheckerId { get; set; }
        public int TicketId { get; set; }
        public decimal PenaltyAmount { get; set; }
        public DateTime PenaltyDate { get; set; }

        public TicketChecker TicketChecker { get; set; }
        public Ticket Ticket { get; set; }
    }
}
