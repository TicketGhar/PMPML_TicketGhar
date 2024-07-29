namespace PMPML_TicketGhar.Models
{
    public class Conductor
    {
        public int ConductorId { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int BusId { get; set; }

        public Bus Bus { get; set; }
    }
}
