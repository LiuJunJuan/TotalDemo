using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreFirst.Models
{
    public partial class ktlContext : DbContext
    {
        public ktlContext()
        {
        }

        public ktlContext(DbContextOptions<ktlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApiLogs> ApiLogs { get; set; }
        public virtual DbSet<EventCard> EventCard { get; set; }
        public virtual DbSet<EventDate> EventDate { get; set; }
        public virtual DbSet<EventDet> EventDet { get; set; }
        public virtual DbSet<EventDetPhoto> EventDetPhoto { get; set; }
        public virtual DbSet<EventDetStamp> EventDetStamp { get; set; }
        public virtual DbSet<EventHdr> EventHdr { get; set; }
        public virtual DbSet<EventHdrPhoto> EventHdrPhoto { get; set; }
        public virtual DbSet<EventTimeSlot> EventTimeSlot { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAddress> MemberAddress { get; set; }
        public virtual DbSet<MemberPoint> MemberPoint { get; set; }
        public virtual DbSet<MemberStamp> MemberStamp { get; set; }
        public virtual DbSet<OrderDet> OrderDet { get; set; }
        public virtual DbSet<OrderHdr> OrderHdr { get; set; }
        public virtual DbSet<SaleTransDet> SaleTransDet { get; set; }
        public virtual DbSet<SaleTransHdr> SaleTransHdr { get; set; }
        public virtual DbSet<SlotQty> SlotQty { get; set; }
        public virtual DbSet<TicketDet> TicketDet { get; set; }
        public virtual DbSet<TicketDetCode> TicketDetCode { get; set; }
        public virtual DbSet<TicketHdr> TicketHdr { get; set; }
        public virtual DbSet<TicketHdrCode> TicketHdrCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=ktl;User ID=sa;Password=123456; MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiLogs>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__ApiLogs__LogId");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Desc).IsRequired();

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EventCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__CardId");

                entity.Property(e => e.BackendDesc)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrizeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrizePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.EventCard)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventCard_EventHdr");
            });

            modelBuilder.Entity<EventDate>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.EventDate)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventDate_EventHdr");
            });

            modelBuilder.Entity<EventDet>(entity =>
            {
                entity.HasIndex(e => e.EventHdrId);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.IconImage).HasMaxLength(300);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MallLocation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PromotionalMsg).IsRequired();

                entity.Property(e => e.SubEventType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TimeFrom)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TimeTo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.EventDet)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventDet__EventHdrId");
            });

            modelBuilder.Entity<EventDetPhoto>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.EventDetPhoto)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventDetPhoto_EventDet");
            });

            modelBuilder.Entity<EventDetStamp>(entity =>
            {
                entity.HasKey(e => e.StampId)
                    .HasName("PK__StampId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StampIconName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.StampIconPath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UnstampIconName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UnstampIconPath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.EventDetStamp)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventDetStamp_EventDet");
            });

            modelBuilder.Entity<EventHdr>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PromotionIcon).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EventHdrPhoto>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.EventHdrPhoto)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventHdrPhoto_EventHdr");
            });

            modelBuilder.Entity<EventTimeSlot>(entity =>
            {
                entity.HasKey(e => e.SlotId)
                    .HasName("PK__EventTim__SlotId");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExceptionDate).HasColumnType("date");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeSlotFrom)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TimeSlotTo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TimeSlotType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.EventTimeSlot)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventTimeSlot_EventDet");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.AvatarUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.SessionKey)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.WeChatOpenId)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberAddress>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberAddress)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberAddress_Member");
            });

            modelBuilder.Entity<MemberPoint>(entity =>
            {
                entity.HasIndex(e => e.MemberPointId)
                    .HasName("IX_MemberPoint");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberPoint)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberPoint_Member");
            });

            modelBuilder.Entity<MemberStamp>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.MemberStamp)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberStamp_EventDet");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberStamp)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberStamp_Member");
            });

            modelBuilder.Entity<OrderDet>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDet)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDet_OrderHdr");
            });

            modelBuilder.Entity<OrderHdr>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderHdr__OrderId");

                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_OrderHdr_WeChatOpenId");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.WeChatName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WeChatOpenId)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.WeChatPrePayId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.OrderHdr)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderHdr_Member");
            });

            modelBuilder.Entity<SaleTransDet>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ReviewComment).HasMaxLength(300);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OrderDet)
                    .WithMany(p => p.SaleTransDet)
                    .HasForeignKey(d => d.OrderDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleTransDet_OrderDet");

                entity.HasOne(d => d.SaleTransHdr)
                    .WithMany(p => p.SaleTransDet)
                    .HasForeignKey(d => d.SaleTransHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleTransDet_SaleTransHdr");
            });

            modelBuilder.Entity<SaleTransHdr>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.SaleTransHdr)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleTransHdr_EventHdr");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SaleTransHdr)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleTransHdr_OrderHdr");
            });

            modelBuilder.Entity<SlotQty>(entity =>
            {
                entity.Property(e => e.AttractionDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.SlotQty)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotQty_EventDet");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.SlotQty)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotQty_EventTimeSlot");
            });

            modelBuilder.Entity<TicketDet>(entity =>
            {
                entity.Property(e => e.AttractionDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlotTimeFrom).HasMaxLength(10);

                entity.Property(e => e.SlotTimeTo).HasMaxLength(10);

                entity.HasOne(d => d.EventDet)
                    .WithMany(p => p.TicketDet)
                    .HasForeignKey(d => d.EventDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketDet_EventDet");

                entity.HasOne(d => d.OrderDet)
                    .WithMany(p => p.TicketDet)
                    .HasForeignKey(d => d.OrderDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketDet_OrderDet");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.TicketDet)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK_TicketDet_EventTimeSlot");

                entity.HasOne(d => d.TicketHdr)
                    .WithMany(p => p.TicketDet)
                    .HasForeignKey(d => d.TicketHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketDet_TicketHdr");
            });

            modelBuilder.Entity<TicketDetCode>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PK__TicketDetCode__CodeId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TicketDet)
                    .WithMany(p => p.TicketDetCode)
                    .HasForeignKey(d => d.TicketDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketDetCode_TicketDet");
            });

            modelBuilder.Entity<TicketHdr>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketDate).HasColumnType("datetime");

                entity.HasOne(d => d.EventHdr)
                    .WithMany(p => p.TicketHdr)
                    .HasForeignKey(d => d.EventHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHdr_EventHdr");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TicketHdr)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHdr_OrderHdr");
            });

            modelBuilder.Entity<TicketHdrCode>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PK__TicketHdrCode__CodeId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TicketHdr)
                    .WithMany(p => p.TicketHdrCode)
                    .HasForeignKey(d => d.TicketHdrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHdrCode_TicketHdr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
