using Bradop.StockWebApi.Helper;
using Domain.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bradop.StockWebApi.Models.Persistance
{
    public class StockRepository : IStockRepository
    {
        public bool Add(Stock stock, out string message)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Save(stock);
                        transaction.Commit();
                    }
                    message = "ok";
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public Stock Get(int id)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    return session.Get<Stock>(id);
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return null;
            }            
        }

        public IEnumerable<Stock> GetAll()
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    return session.Query<Stock>().ToList();
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return null;
            }
        }

        public bool Update(Stock stock, out string message)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(stock);
                        transaction.Commit();
                    }
                }
                message = "ok";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        bool IStockRepository.Delete(int id, out string message)
        {
            var stock = Get(id);

            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(stock);
                        transaction.Commit();
                    }
                }
                message = "ok";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}