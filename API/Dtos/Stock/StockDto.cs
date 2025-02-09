using API.Dtos.Comment;
using API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string Companyname { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public int MarketCap { get; set; }
        public List<CommentDto> comments { get; set; }
        
    }
}
