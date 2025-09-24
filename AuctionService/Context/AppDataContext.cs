using Microsoft.EntityFrameworkCore;
using AuctionService.Entities;

namespace AuctionService.Context
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
