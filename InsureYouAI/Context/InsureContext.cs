using InsureYouAI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.Context
{
    public class InsureContext
    {
        public class InsureContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer("Server=ESRA\\SQLEXPRESS;initial" +
                    "catalog=InsureDb;integrated security=true;trust server certficate=true");
            }
            public DbSet<About> Abouts { get; set; }
            public DbSet<AboutItem> Blogs { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Message> Messages { get; set; }
            public DbSet<PricingPlan> PricingPlans { get; set;
  
                public DbSet<Service> Services { get; set; }
            public DbSet<Slider> Sliders { get; set; }
            public DbSet<Testimonial> Testimonials { get; set; }
            public DbSet<TrailerVideo> TrailerVideo
            { get; set; }

            }
    }
}
