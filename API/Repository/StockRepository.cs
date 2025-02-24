﻿using API.Data;
using API.Dtos.Stock;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context) 
        { 
        _context = context;
        }

        public async Task<Stock?> CreateAsync(Stock stockModel)
        {
           await _context.Stocks.AddAsync(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
        }   

        public async Task<Stock?> DeleteAsync(int id)
        {
           var stockModel = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);
            if(stockModel == null)
            {
                return null;
            }
            _context.Stocks.Remove(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
        }

        public async Task<List<Stock>> GetAllAsynce()
        {
            return await _context.Stocks.Include(c => c.Comments).ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
           return await _context.Stocks.Include(c => c.Comments).FirstOrDefaultAsync(i => i.Id == id );
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var existingStock = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);
            if(existingStock == null)
            {
                return null;
            }

            existingStock.Symbol = stockDto.Symbol;
            existingStock.Companyname = stockDto.Companyname;
            existingStock.Purchase = stockDto.Purchase;
            existingStock.LastDiv = stockDto.LastDiv;
            existingStock.Industry = stockDto.Industry;
            existingStock.MarketCap = stockDto.MarketCap;
            await _context.SaveChangesAsync();
            return existingStock;
        }
    }
}
