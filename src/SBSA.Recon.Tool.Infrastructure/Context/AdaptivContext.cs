using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SBSA.Recon.Tool.Infrastructure.Entities;

namespace SBSA.Recon.Tool.Infrastructure.Context
{
    public partial class AdaptivContext : DbContext
    {
        public AdaptivContext()
        {
        }

        public AdaptivContext(DbContextOptions<AdaptivContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdaptivRecon> AdaptivRecon { get; set; }
        public virtual DbSet<MetaAdaptivReconComment> MetaAdaptivReconComment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Adaptiv;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdaptivRecon>(entity =>
            {
                entity.Property(e => e.AdaptivReconId).HasColumnName("AdaptivReconID");

                entity.Property(e => e.AdaptivLogComment)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.AdaptivLogEvent)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Aggregation).HasMaxLength(800);

                entity.Property(e => e.CdsbusinessDate)
                    .HasColumnName("CDSBusinessDate")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CdsbusinessDateSkey)
                    .HasColumnName("CDSBusinessDate_Skey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counterparty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ItemInSource)
                    .HasColumnName("Item_In_Source")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ItemInTarget)
                    .HasColumnName("Item_In_Target")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLogDeliveredNotInTarget)
                    .HasColumnName("Item_LogDelivered_Not_In_Target")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MarkToMarketCurrency)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MarketToMarket)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaturityDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddlewareCiferrException)
                    .HasColumnName("Middleware_CIFErrException")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MiddlewareErrException)
                    .HasColumnName("Middleware_ErrException")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MiddlewareLogDelivered)
                    .HasColumnName("Middleware_LogDelivered")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MiddlewareLogFilter)
                    .HasColumnName("Middleware_LogFilter")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Notional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondGeneration).HasMaxLength(800);

                entity.Property(e => e.SettlementDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.SourceReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradeDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetaAdaptivReconComment>(entity =>
            {
                entity.HasKey(e => e.CommentKey);

                entity.Property(e => e.CommentKey).HasColumnName("Comment_Key");

                entity.Property(e => e.AdaptivReconId)
                    .IsRequired()
                    .HasColumnName("AdaptivReconID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDate).IsUnicode(false);

                entity.Property(e => e.CommentDate)
                    .HasColumnName("Comment_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ReconStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });
        }
    }
}
