using Bradop.StockWebApi.Business;
using Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bradop.StockWebApi.Controllers
{
    public class StockController : ApiController
    {
        IStockService _stockService = new StockService();

     
        [HttpGet]
        public IEnumerable<Stock> GetAll()
        {
            return _stockService.GetAll();
        }

        [HttpGet]
        public Stock GetStockById(int id)
        {
            var stock = _stockService.Get(id);

            if (stock == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return stock;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteStock(int id)
        {
            var stock = _stockService.Get(id);
            var message = "";

            if (stock == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Request.CreateErrorResponse(_stockService.Delete(id, out message) ? HttpStatusCode.OK : HttpStatusCode.InternalServerError, message);
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostStock(HttpRequestMessage request)
        {
            _stockService = new StockService();
            var message = "";
            var jsonString = await request.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Stock>(jsonString);

            return new HttpResponseMessage(_stockService.Add(model, out message) ? HttpStatusCode.OK : HttpStatusCode.InternalServerError);
        }

        [HttpPut]
        public async Task<HttpResponseMessage> PutStock(int id, HttpRequestMessage request)
        {
            _stockService = new StockService();
            var message = "";
            var jsonString = await request.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Stock>(jsonString);

            model.Id = id;

            return Request.CreateErrorResponse(_stockService.Update(model, out message) ? HttpStatusCode.OK : HttpStatusCode.InternalServerError, message);
        }     
    }
}
