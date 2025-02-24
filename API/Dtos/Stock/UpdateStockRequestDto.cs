﻿namespace API.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        public string Symbol { get; set; } = string.Empty;
        public string Companyname { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public int MarketCap { get; set; }
    }
}
