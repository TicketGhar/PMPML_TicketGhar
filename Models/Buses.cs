using System.Net.Sockets;

namespace PMPML_TicketGhar.Models
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusNumber { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Conductor> Conductors { get; set; }
        public ICollection<GuestTicket> GuestTickets { get; set; }
    }
}
