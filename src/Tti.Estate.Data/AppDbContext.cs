using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<County> Counties { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>(ConfigureCity);
            builder.Entity<Comment>(ConfigureComment);
            builder.Entity<Contact>(ConfigureContact);
            builder.Entity<County>(ConfigureCounty);
            builder.Entity<Customer>(ConfigureCustomer);
            builder.Entity<Property>(ConfigureProperty);
            builder.Entity<Photo>(ConfigurePhoto);
            builder.Entity<Transaction>(ConfigureTransaction);
            builder.Entity<User>(ConfigureUser);

            builder.Entity<County>(ConfigureCountyData);
            builder.Entity<City>(ConfigureCityData);
        }

        private void ConfigureCity(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(x => x.County)
                .WithMany(x => x.Cities)
                .HasForeignKey(x => x.CountyId);
        }

        private void ConfigureContact(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();
            
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasMaxLength(50);

            builder.Property(x => x.Telephone)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasMaxLength(254);

            builder.HasOne(x => x.Property)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.PropertyId);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.CustomerId);
        }

        private void ConfigureComment(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();
            
            builder.Property(x => x.Text)
                .IsRequired();

            builder.Property(x => x.Created)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Property)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PropertyId);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Transaction)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.TransactionId);
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.Description);

            builder.Property(x => x.Created)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Modified);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureProperty(EntityTypeBuilder<Property> builder)
        {
            builder.ToTable("Property");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.PropertyType);

            builder.Property(x => x.TransactionType);

            builder.Property(x => x.Status);

            builder.Property(x => x.Price).
                HasColumnType("decimal(12,2)");

            builder.Property(x => x.HasVat)
                .HasDefaultValue(false);

            builder.Property(x => x.Street)
                .HasMaxLength(64);

            builder.Property(x => x.HouseNumber)
                .HasMaxLength(8);

            builder.Property(x => x.ApartmentNumber)
                .HasMaxLength(8);

            builder.Property(x => x.CadastralNumber)
                .HasMaxLength(128);

            builder.Property(x => x.Area)
                .HasColumnType("decimal(5,2)");

            builder.Property(x => x.LandArea)
                .HasColumnType("decimal(5,2)");

            builder.Property(x => x.Floor);

            builder.Property(x => x.FloorCount);

            builder.Property(x => x.IsRestricted)
                .HasDefaultValue(false);

            builder.Property(x => x.Description);

            builder.Property(x => x.Created)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Modified);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.County)
                .WithMany()
                .HasForeignKey(x => x.CountyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.City)
                .WithMany()
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigurePhoto(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photo");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.IsDefault).
                HasDefaultValue(false);

            builder.Property(x => x.ExternalId)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Property)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.PropertyId);
        }

        private void ConfigureCounty(EntityTypeBuilder<County> builder)
        {
            builder.ToTable("County");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
        }

        private void ConfigureTransaction(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.TransactionType);

            builder.Property(x => x.Status);

            builder.Property(x => x.Date);

            builder.Property(x => x.Amount).
                HasColumnType("decimal(12,2)");

            builder.Property(x => x.CompanyPercent);

            builder.Property(x => x.UserPercent);

            builder.Property(x => x.Description);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Property)
                .WithMany()
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.Role);

            builder.Property(x => x.Status);

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Telephone)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.HasIndex(x => x.UserName)
                .IsUnique();
        }
    }
}
