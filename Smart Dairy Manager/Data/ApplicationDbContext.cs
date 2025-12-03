using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smart_Dairy_Manager.Data_model;

namespace Smart_Dairy_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cow> Cows { get; set; } = default!;
        public DbSet<FeedManagement> FeedManagements { get; set; } = default!;
        public DbSet<MeatProduction> MeatProductions { get; set; } = default!;
        public DbSet<Vaccine> vaccines { get; set; } = default!;
        public DbSet<VaccineApply> VaccineApplies { get; set; } = default!;
        public DbSet<MilkCollection> MilkCollections { get; set; } = default!;
    }
}