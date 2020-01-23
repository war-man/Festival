﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ClassLibrary.Models
{
    public class FestivalContext : DbContext
    {
        public DbSet<Performer> Performer { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Performance> Performance { get; set; }
        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<ShopItem> ShopItem { get; set; }
        public DbSet<TransferReservation> TransferReservation { get; set; }
        public DbSet<Accommodation> Accommodation { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<TransferVehicle> TransferVehicle { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<TicketVoucher> TicketVoucher { get; set; }
        public DbSet<PurchaseVoucher> PurchaseVoucher { get; set; }
        public DbSet<TransferService> TransferService { get; set; }
        public DbSet<Image> Image { get; set; }
       
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                  optionsBuilder.UseSqlServer(@" Server=app.fit.ba, 1431;
            
                                            Database=Festival;

                                            Trusted_Connection=False;

                                            MultipleActiveResultSets=true;

                                            User ID=festivalUser;

                                            Password=f9pctz!");

        }
        
    }
}