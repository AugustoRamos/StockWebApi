using Bradop.StockWebApi.DTO;
using Bradop.StockWebApi.Models;
using Domain.Models;
using System.Collections.Generic;

namespace Bradop.StockWebApi.Business
{
    public interface IStockService
    {
        Stock Get(int id);
        IEnumerable<Stock> GetAll();
        bool Add(Stock stock, out string message);
        bool Delete(int id, out string message);
        bool Update(Stock stock, out string message);
    }
}
