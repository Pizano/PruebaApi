using PruebaNetFramework.Models;
using PruebaNetFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PruebaNetFramework.Controllers
{
    [Route("api/[controller]")]
    public class ArticuloApiController : ApiController
    {
        private readonly PruebaNetFramework.Data.InventarioDbContext _InventarioContext;
        private readonly IArticuloServices _services;
        public ArticuloApiController(PruebaNetFramework.Data.InventarioDbContext InventarioContext, IArticuloServices services)
        {
            _InventarioContext = InventarioContext;
            _services = services;
        }
        public ArticuloApiController()
        {
          
        }
  
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            return await _services.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetById(int? id)
        {
            return await _services.GetById(id);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] ArticuloViewModel model)
        {
            return await _services.Create(model);

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IHttpActionResult> Delete(int? id)
        {
            return await _services.delete(id);
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put([FromBody] ArticuloViewModel model)
        {
            return await _services.Update(model);

        }
    }
}