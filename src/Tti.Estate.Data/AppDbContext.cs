using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyPhoto> PropertyPhotos { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contact>(ConfigureContact);
            builder.Entity<Comment>(ConfigureComment);
            builder.Entity<Customer>(ConfigureCustomer);
            builder.Entity<Property>(ConfigureProperty);
            builder.Entity<PropertyPhoto>(ConfigurePropertyPhoto);
            builder.Entity<Region>(ConfigureRegion);
            builder.Entity<Street>(ConfigureStreet);
            builder.Entity<Transaction>(ConfigureTransaction);
            builder.Entity<User>(ConfigureUser);
        }

        private void ConfigureContact(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).IsUnicode().HasMaxLength(50);
            builder.Property(x => x.LastName).IsUnicode().HasMaxLength(50);
            builder.Property(x => x.Telephone).HasMaxLength(50);
            builder.Property(x => x.Email).IsUnicode().HasMaxLength(50);

            builder.HasOne(x => x.Property).WithMany(x => x.Contacts);
            builder.HasOne(x => x.Customer).WithMany(x => x.Contacts);
        }

        private void ConfigureComment(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Text).IsUnicode().IsRequired();
            builder.Property(x => x.Created).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Property).WithMany(x => x.Comments).HasForeignKey(x => x.PropertyId).IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.Comments).HasForeignKey(x => x.CustomerId).IsRequired();
            builder.HasOne(x => x.Transaction).WithMany(x => x.Comments).HasForeignKey(x => x.TransactionId).IsRequired();
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.Created).ValueGeneratedOnAdd();
            builder.Property(x => x.Modified).ValueGeneratedOnAddOrUpdate();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).IsRequired();
        }

        private void ConfigureProperty(EntityTypeBuilder<Property> builder)
        {
            builder.ToTable("Property");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.PropertyType);
            builder.Property(x => x.TransactionType);
            builder.Property(x => x.Status);
            builder.Property(x => x.Price);
            builder.Property(x => x.PriceType);
            builder.Property(x => x.HouseNumber).IsUnicode().HasMaxLength(20);
            builder.Property(x => x.FlatNumber).IsUnicode().HasMaxLength(10);
            builder.Property(x => x.Area);
            builder.Property(x => x.LandArea);
            builder.Property(x => x.Floor);
            builder.Property(x => x.FloorCount);
            builder.Property(x => x.IsVip).HasDefaultValue(false);
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.Created).ValueGeneratedOnAdd();
            builder.Property(x => x.Modified).ValueGeneratedOnAddOrUpdate();

            builder.HasOne(x => x.User).WithMany().IsRequired();
            builder.HasOne(x => x.Region).WithMany().IsRequired();
            builder.HasOne(x => x.Street).WithMany().IsRequired();
        }

        private void ConfigurePropertyPhoto(EntityTypeBuilder<PropertyPhoto> builder)
        {
            builder.ToTable("PropertyPhoto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.IsMain).HasDefaultValue(false);
        }

        private void ConfigureRegion(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsUnicode().IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Parent).WithMany(x => x.Childrens);
        }

        private void ConfigureStreet(EntityTypeBuilder<Street> builder)
        {
            builder.ToTable("Street");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsUnicode().IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Region).WithMany();
        }

        private void ConfigureTransaction(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TransactionType);
            builder.Property(x => x.Status);
            builder.Property(x => x.Date);
            builder.Property(x => x.Amount);
            builder.Property(x => x.CompanyPercent);
            builder.Property(x => x.UserPercent);
            builder.Property(x => x.Description).IsUnicode();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).IsRequired();
            builder.HasOne(x => x.Property).WithMany();
            builder.HasOne(x => x.Customer).WithMany();
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UserName).IsUnicode().IsRequired().HasMaxLength(256);
            builder.Property(x => x.FirstName).IsUnicode().IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsUnicode().IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telephone).HasMaxLength(50);
        }
    }
}
