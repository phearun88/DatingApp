using API.Dtos.Comment;
using API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = " Symbol cannot be over 10 over characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = " Company Name cannot be over 10 over characters")]
        public string Companyname { get; set; } = string.Empty;
        [Required]
        [Range(1, 1000000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 50000000000)]
        public int MarketCap { get; set; }
        public List<CommentDto> comments { get; set; }
        
    }
}



