using CagemCodeFirstProject.DAL.Entities;
using System.Data.Entity;

namespace CagemCodeFirstProject.DAL.Context
{
    public class TravelContext:DbContext
    {
        public DbSet<Booking> Bookings{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Destination> Destinations{ get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Admin> Adimins{ get; set; }
    }
}