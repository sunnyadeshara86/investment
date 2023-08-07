using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;
using Investment.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Investment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        public DbSet<FamilyMember> FamilyMembers { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<MutualFund> MutualFunds { get; set; }

        public DbSet<FixedDeposit> FixedDeposits { get; set; }

        public DbSet<PostOfficeSaving> PostOfficeSavings { get; set; }

        public DbSet<NationalSavingCertificate> NationalSavingCertificates { get; set; }

        public DbSet<ProvidentFund> ProvidentFunds { get; set; }

        public DbSet<Cash> Cash { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<PersonalProvidentFund> PersonalProvidentFunds { get; set; }

        public DbSet<ResedentialProperty> ResedentialProperties { get; set; }

        public DbSet<CommercialProperty> CommercialProperties { get; set; }

        public DbSet<AgriCultureProperty> AgriCultureProperties { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Jewellery> Jewelleries { get; set; }

        public DbSet<OtherProperty> OtherProperties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("People");
            modelBuilder.Entity<FamilyMember>().ToTable("FamilyMembers");

            modelBuilder.Entity<Person>().OwnsOne(x => x.Address).Property(x => x.AddressLine);
            modelBuilder.Entity<Person>().OwnsOne(x => x.Address).Property(x => x.City);
            modelBuilder.Entity<Person>().OwnsOne(x => x.Address).Property(x => x.State);
            modelBuilder.Entity<Person>().OwnsOne(x => x.Address).Property(x => x.Country);
            modelBuilder.Entity<Person>().OwnsOne(x => x.Address).Property(x => x.PINCode);
            modelBuilder.Entity<Person>().OwnsOne(x => x.CommunicationInfo).Property(x => x.PhoneNumber);
            modelBuilder.Entity<Person>().OwnsOne(x => x.CommunicationInfo).Property(x => x.AlternatePhoneNumber);
            modelBuilder.Entity<Person>().OwnsOne(x => x.CommunicationInfo).Property(x => x.EmailAddress);

            modelBuilder.Entity<Organization>().OwnsOne(x => x.Address).Property(x => x.AddressLine);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.Address).Property(x => x.City);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.Address).Property(x => x.State);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.Address).Property(x => x.Country);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.Address).Property(x => x.PINCode);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.CommunicationInfo).Property(x => x.PhoneNumber);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.CommunicationInfo).Property(x => x.AlternatePhoneNumber);
            modelBuilder.Entity<Organization>().OwnsOne(x => x.CommunicationInfo).Property(x => x.EmailAddress);

            base.OnModelCreating(modelBuilder);
        }
    }
}
