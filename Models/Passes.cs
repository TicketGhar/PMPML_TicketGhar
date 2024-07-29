namespace PMPML_TicketGhar.Models
{
    public class Pass
    {
        public int PassId { get; set; }
        public int UserId { get; set; }
        public string PassType { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public User User { get; set; }
    }
}
