using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
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
            builder.Entity<Transaction>(ConfigureTransaction);
            builder.Entity<User>(ConfigureUser);
        }

        private void ConfigureContact(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();
            
            builder.Property(x => x.FirstName)
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasMaxLength(50);

            builder.Property(x => x.Telephone)
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

            builder.Property(x => x.Modified)
                .ValueGeneratedOnAddOrUpdate();

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

            builder.Property(x => x.Street)
                .HasMaxLength(50);

            builder.Property(x => x.HouseNumber)
                .HasMaxLength(20);

            builder.Property(x => x.FlatNumber)
                .HasMaxLength(10);

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

            builder.Property(x => x.Modified)
                .ValueGeneratedOnUpdate();

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Region)
                .WithMany()
                .HasForeignKey(x => x.RegionId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigurePropertyPhoto(EntityTypeBuilder<PropertyPhoto> builder)
        {
            builder.ToTable("PropertyPhoto");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.IsDefault).
                HasDefaultValue(false);

            builder.Property(x => x.ExternalId);

            builder.HasOne(x => x.Property)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.PropertyId);
        }

        private void ConfigureRegion(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region");

            builder.HasKey(x => x.Id).
                ForSqlServerIsClustered();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(x => x.Parent)
                .WithMany(x => x.Childrens);
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
