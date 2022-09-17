using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.Models
{
    public partial class aspnetdotnetApp6A130FB599AC4AF58FCD86B78C5EA630Context : DbContext
    {
        public aspnetdotnetApp6A130FB599AC4AF58FCD86B78C5EA630Context()
        {
        }

        public aspnetdotnetApp6A130FB599AC4AF58FCD86B78C5EA630Context(DbContextOptions<aspnetdotnetApp6A130FB599AC4AF58FCD86B78C5EA630Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TradingSite> TradingSites { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=aspnet-dotnetApp-6A130FB5-99AC-4AF5-8FCD-86B78C5EA630;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradingSite>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Api_Status");

                entity.Property(e => e.ApiV2Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ApiV2_Status");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
