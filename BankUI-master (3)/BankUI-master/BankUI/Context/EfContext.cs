using BankUI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankUI.Context
{
    public class EfContext:DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options) { }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Requisition> Requisitions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SiliderBar> SiliderBars { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
