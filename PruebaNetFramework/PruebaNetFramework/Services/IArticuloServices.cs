using PruebaNetFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace PruebaNetFramework.Services
{
    public interface IArticuloServices
    {
        Task<IHttpActionResult> GetAll();
        Task<IHttpActionResult> GetById(int? id);
        Task<IHttpActionResult> Create(ArticuloViewModel model);
        Task<IHttpActionResult> delete(int? id);
        Task<IHttpActionResult> Update(ArticuloViewModel model);
    }
}