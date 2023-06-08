using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Dal.Contexts
{
    public class AutoShopContext : DbContext
    {
        public DbSet<BaseProduct> BaseProducts { get; set; } = null!;
        public DbSet<Candle> Candles { get; set; } = null!;
        public DbSet<Filter> Filters { get; set; } = null!;
        public DbSet<Oil> Oils { get; set; } = null!;
        public DbSet<Pad> Pads { get; set; } = null!;
        public DbSet<Wiper> Wipers { get; set; } = null!;

        public AutoShopContext(DbContextOptions<AutoShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candle>().HasData(
                new Candle { Id = 1, Name = "Candle1", imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.jfif?updatedAt=1685827454525", Price = 80 },
                new Candle { Id = 2, Name = "Candle2", imgSrc = "https://ik.imagekit.io/i8gs619wfp/2.jpeg?updatedAt=1685827454853", Price = 90 },
                new Candle { Id = 3, Name = "Candle3", imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jpg?updatedAt=1685827454580", Price = 100 },
                new Candle { Id = 4, Name = "Candle4", imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.jfif?updatedAt=1685827454594", Price = 110 },
                new Candle { Id = 5, Name = "Candle5", imgSrc = "https://ik.imagekit.io/i8gs619wfp/5.jfif?updatedAt=1685827454567", Price = 120 }
                );
            modelBuilder.Entity<Filter>().HasData(
                new Filter { Id = 6, Name = "Filter1", imgSrc = "https://ik.imagekit.io/i8gs619wfp/1_1_.jfif?updatedAt=1685827457946", Price = 80 },
                new Filter { Id = 7, Name = "Filter2", imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_2_.jpg?updatedAt=1685827458352", Price = 90 },
                new Filter { Id = 8, Name = "Filter3", imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jfif?updatedAt=1685827457943", Price = 100 },
                new Filter { Id = 9, Name = "Filter4", imgSrc = "https://ik.imagekit.io/i8gs619wfp/4_1_.jfif?updatedAt=1685827457685", Price = 110 },
                new Filter { Id = 10, Name = "Filter5", imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_2_.jfif?updatedAt=1685827457863", Price = 120 }
                );
            modelBuilder.Entity<Oil>().HasData(
                new Oil { Id = 11, Name = "Oil1", imgSrc = "https://ik.imagekit.io/i8gs619wfp/1_1_.jpg?updatedAt=1685827460666", Price = 80 },
                new Oil { Id = 12, Name = "Oil2", imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_3_.jpg?updatedAt=1685827460895", Price = 90 },
                new Oil { Id = 13, Name = "Oil3", imgSrc = "https://ik.imagekit.io/i8gs619wfp/3_2_.jpg?updatedAt=1685827460952", Price = 100 },
                new Oil { Id = 14, Name = "Oil4", imgSrc = "https://ik.imagekit.io/i8gs619wfp/4_1_.jpg?updatedAt=1685827460517", Price = 110 },
                new Oil { Id = 15, Name = "Oil5", imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_1_.jpg?updatedAt=1685827460692", Price = 120 }
                );
            modelBuilder.Entity<Pad>().HasData(
                new Oil { Id = 16, Name = "Pad1", imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.jpg?updatedAt=1685827454696", Price = 80 },
                new Oil { Id = 17, Name = "Pad2", imgSrc = "https://ik.imagekit.io/i8gs619wfp/2.jpg?updatedAt=1685827454879", Price = 90 },
                new Oil { Id = 18, Name = "Pad3", imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jpeg?updatedAt=1685827454840", Price = 100 },
                new Oil { Id = 19, Name = "Pad4", imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.png?updatedAt=1685827455133", Price = 110 },
                new Oil { Id = 20, Name = "Pad5", imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_1_.jfif?updatedAt=1685827454582", Price = 120 }
                );
            modelBuilder.Entity<Wiper>().HasData(
                new Oil { Id = 21, Name = "Wiper1", imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_1_.jpg?updatedAt=1685827457778", Price = 80 },
                new Oil { Id = 22, Name = "Wiper2", imgSrc = "https://ik.imagekit.io/i8gs619wfp/5.jpg?updatedAt=1685827457699", Price = 90 },
                new Oil { Id = 23, Name = "Wiper3", imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.webp?updatedAt=1685827457985", Price = 100 },
                new Oil { Id = 24, Name = "Wiper4", imgSrc = "https://ik.imagekit.io/i8gs619wfp/3_1_.jpg?updatedAt=1685827457654", Price = 110 },
                new Oil { Id = 25, Name = "Wiper5", imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.jpg?updatedAt=1685827457551", Price = 120 }
                );
        }
    }
}
