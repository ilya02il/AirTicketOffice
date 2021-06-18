using System.Data.Entity;
using AirTicketOffice.DAL.Entities;

namespace AirTicketOffice.DAL.Implementations
{
    public class DataContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<TicketPriceEntity> TicketPrices { get; set; }
        public DbSet<FlightEntity> Flights { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PlaneEntity> Planes { get; set; }
        public DbSet<ClassEntity> Classes { get; set; }
        public DbSet<SeatEntity> Seats { get; set; }
        public DbSet<CrewMemberEntity> CrewMembers { get; set; }
        public DbSet<RouteEntity> Routes { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<AirportEntity> Airports { get; set; }

        public DataContext()
        {
            
        }
        public DataContext(string connectionString) : base(connectionString)
        {
            
        }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RouteEntity>()
				.HasRequired(r => r.DepartureAirport)
				.WithMany(a => a.DepartureRoutes)
				.HasForeignKey(r => r.DepartureAirportId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<RouteEntity>()
				.HasRequired(r => r.ArrivalAirport)
				.WithMany(a => a.ArrivalRoutes)
				.HasForeignKey(r => r.ArrivalAirportId)
				.WillCascadeOnDelete(false);
		}
	}
}
