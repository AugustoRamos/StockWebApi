using System;
using System.Collections.Generic;
using Bradop.StockWebApi.DTO;
using Bradop.StockWebApi.Models;
using Bradop.StockWebApi.Models.Persistance;
using Domain.Models;

namespace Bradop.StockWebApi.Business
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository = new StockRepository();

        public bool Add(Stock stock, out string message)
        {
            message = "";
            if (stock != null)
                return _stockRepository.Add(stock, out message);
            return false;
        }

        public bool Delete(int id, out string message)
        {
            message = "";
            if (id > 0)
                return _stockRepository.Delete(id, out message);
            return false;
        }

        public Stock Get(int id)
        {
            if (id > 0)
                return _stockRepository.Get(id);
            return null;
        }

        public IEnumerable<Stock> GetAll()
        {
            return _stockRepository.GetAll();
        }

        public bool Update(Stock stock, out string message)
        {
            message = "";
            if (stock != null)
                return _stockRepository.Update(stock, out message);
            return false;
        }
    }
}