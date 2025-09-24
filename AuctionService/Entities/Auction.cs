using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; }

        public int ReservePrice { get; set; } = 0;

        public string Seller { get; set; } = string.Empty;

        public string Winner { get; set; } = string.Empty;

        public int? SoldAmount { get; set; } = null;

        public int? CurrentHightBid { get; set; } = null;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

        public DateTime ActionEnd { get; set; }

        public required Status Status { get; set; }

        public required Item Item { get; set; }
    }
}