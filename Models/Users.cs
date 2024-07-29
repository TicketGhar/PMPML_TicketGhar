using System.Net.Sockets;

namespace PMPML_TicketGhar.Models

{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AadhaarNumber { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Pass> Passes { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
