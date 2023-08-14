using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataObject.Models
{
    public partial class CarParkingManagementSystemContext : DbContext
    {
        public CarParkingManagementSystemContext()
        {
        }

        public CarParkingManagementSystemContext(DbContextOptions<CarParkingManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<ParkingRate> ParkingRates { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=CarParkingManagementSystem;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CarID");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.ExitTime).HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Booking__CarID__5165187F");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.BookingMembers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Booking__MemberI__52593CB8");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.BookingStatusNavigations)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__StaffID__534D60F1");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CarID");

                entity.Property(e => e.CarTypeId).HasColumnName("CarTypeID");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.ExitTime).HasColumnType("datetime");

                entity.Property(e => e.ParkingFee).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CarType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarTypeId)
                    .HasConstraintName("FK__Car__CarTypeID__4E88ABD4");
            });

            modelBuilder.Entity<ParkingRate>(entity =>
            {
                entity.HasKey(e => e.CarTypeId)
                    .HasName("PK__ParkingR__2B2E84BD7CF20D76");

                entity.ToTable("ParkingRate");

                entity.Property(e => e.CarTypeId).HasColumnName("CarTypeID");

                entity.Property(e => e.RatePerHour).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Users__536C85E4F7BAA0AD")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
