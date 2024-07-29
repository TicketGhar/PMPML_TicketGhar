using Microsoft.EntityFrameworkCore;
using PMPML_TicketGhar.Models;

namespace PMPML_TicketGhar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<GuestTicket> GuestTickets { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<TicketChecker> TicketCheckers { get; set; }
        public DbSet<Penalty> Penalties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
