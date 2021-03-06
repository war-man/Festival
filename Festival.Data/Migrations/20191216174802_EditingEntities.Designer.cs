﻿// <auto-generated />
using Festival.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Festival.Data.Migrations
{
    [DbContext(typeof(FestivalContext))]
    [Migration("20191216174802_EditingEntities")]
    partial class EditingEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibrary.Models.Accommodation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Distance")
                        .HasColumnType("real");

                    b.Property<int?>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ImageID");

                    b.ToTable("Accommodation");
                });

            modelBuilder.Entity("ClassLibrary.Models.Attendee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserAccountID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserAccountID");

                    b.ToTable("Attendee");
                });

            modelBuilder.Entity("ClassLibrary.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ClassLibrary.Models.Manager", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("ClassLibrary.Models.Performance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PerformerID")
                        .HasColumnType("int");

                    b.Property<int?>("StageID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PerformerID");

                    b.HasIndex("StageID");

                    b.ToTable("Performance");
                });

            modelBuilder.Entity("ClassLibrary.Models.Performer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Fee")
                        .HasColumnType("real");

                    b.Property<int?>("ImageID")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromoText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ImageID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Performer");
                });

            modelBuilder.Entity("ClassLibrary.Models.Purchase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseVoucherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("ClassLibrary.Models.ShopItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int?>("PurchaseID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ImageID");

                    b.HasIndex("PurchaseID");

                    b.ToTable("ShopItem");
                });

            modelBuilder.Entity("ClassLibrary.Models.Sponsor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ImageID");

                    b.ToTable("Sponsor");
                });

            modelBuilder.Entity("ClassLibrary.Models.Stage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SponsorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SponsorID");

                    b.ToTable("Stage");
                });

            modelBuilder.Entity("ClassLibrary.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<int?>("TicketTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("TicketVoucherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AttendeeID");

                    b.HasIndex("TicketTypeID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("ClassLibrary.Models.TicketType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("TicketType");
                });

            modelBuilder.Entity("ClassLibrary.Models.TransferReservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<int?>("TransferServiceID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AttendeeID");

                    b.HasIndex("TransferServiceID");

                    b.ToTable("TransferReservation");
                });

            modelBuilder.Entity("ClassLibrary.Models.TransferService", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfAvailableSeats")
                        .HasColumnType("int");

                    b.Property<int?>("TransferVehicleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TransferVehicleID");

                    b.ToTable("TransferService");
                });

            modelBuilder.Entity("ClassLibrary.Models.TransferVehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TransferVehicle");
                });

            modelBuilder.Entity("ClassLibrary.Models.UserAccount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserAccount");
                });

            modelBuilder.Entity("ClassLibrary.Models.Voucher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("VoucherTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Voucher");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Voucher");
                });

            modelBuilder.Entity("ClassLibrary.Models.PurchaseVoucher", b =>
                {
                    b.HasBaseType("ClassLibrary.Models.Voucher");

                    b.Property<int?>("PurchaseID")
                        .HasColumnType("int");

                    b.HasIndex("PurchaseID")
                        .IsUnique()
                        .HasFilter("[PurchaseID] IS NOT NULL");

                    b.HasDiscriminator().HasValue("PurchaseVoucher");
                });

            modelBuilder.Entity("ClassLibrary.Models.TicketVoucher", b =>
                {
                    b.HasBaseType("ClassLibrary.Models.Voucher");

                    b.Property<int?>("TicketID")
                        .HasColumnType("int");

                    b.HasIndex("TicketID")
                        .IsUnique()
                        .HasFilter("[TicketID] IS NOT NULL");

                    b.HasDiscriminator().HasValue("TicketVoucher");
                });

            modelBuilder.Entity("ClassLibrary.Models.Accommodation", b =>
                {
                    b.HasOne("ClassLibrary.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Attendee", b =>
                {
                    b.HasOne("ClassLibrary.Models.UserAccount", "Account")
                        .WithMany()
                        .HasForeignKey("UserAccountID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Performance", b =>
                {
                    b.HasOne("ClassLibrary.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerID");

                    b.HasOne("ClassLibrary.Models.Stage", "Stage")
                        .WithMany()
                        .HasForeignKey("StageID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Performer", b =>
                {
                    b.HasOne("ClassLibrary.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");

                    b.HasOne("ClassLibrary.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Purchase", b =>
                {
                    b.HasOne("ClassLibrary.Models.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeID");
                });

            modelBuilder.Entity("ClassLibrary.Models.ShopItem", b =>
                {
                    b.HasOne("ClassLibrary.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");

                    b.HasOne("ClassLibrary.Models.Purchase", null)
                        .WithMany("Items")
                        .HasForeignKey("PurchaseID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Sponsor", b =>
                {
                    b.HasOne("ClassLibrary.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Stage", b =>
                {
                    b.HasOne("ClassLibrary.Models.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorID");
                });

            modelBuilder.Entity("ClassLibrary.Models.Ticket", b =>
                {
                    b.HasOne("ClassLibrary.Models.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeID");

                    b.HasOne("ClassLibrary.Models.TicketType", "Type")
                        .WithMany()
                        .HasForeignKey("TicketTypeID");
                });

            modelBuilder.Entity("ClassLibrary.Models.TransferReservation", b =>
                {
                    b.HasOne("ClassLibrary.Models.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeID");

                    b.HasOne("ClassLibrary.Models.TransferService", "TransferService")
                        .WithMany()
                        .HasForeignKey("TransferServiceID");
                });

            modelBuilder.Entity("ClassLibrary.Models.TransferService", b =>
                {
                    b.HasOne("ClassLibrary.Models.TransferVehicle", "TransferVehicle")
                        .WithMany()
                        .HasForeignKey("TransferVehicleID");
                });

            modelBuilder.Entity("ClassLibrary.Models.PurchaseVoucher", b =>
                {
                    b.HasOne("ClassLibrary.Models.Purchase", "Purchase")
                        .WithOne("PurchaseVoucher")
                        .HasForeignKey("ClassLibrary.Models.PurchaseVoucher", "PurchaseID");
                });

            modelBuilder.Entity("ClassLibrary.Models.TicketVoucher", b =>
                {
                    b.HasOne("ClassLibrary.Models.Ticket", "Ticket")
                        .WithOne("TicketVoucher")
                        .HasForeignKey("ClassLibrary.Models.TicketVoucher", "TicketID");
                });
#pragma warning restore 612, 618
        }
    }
}
