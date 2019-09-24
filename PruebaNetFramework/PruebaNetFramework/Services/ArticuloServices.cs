using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using PruebaNetFramework.Models;
using PruebaNetFramework.Data;
using PruebaNetFramework.EntityModels;
using System.Data.Entity;
using System.Net;

namespace PruebaNetFramework.Services
{
    public class ArticuloServices : ApiController, IArticuloServices
    {
        private readonly PruebaNetFramework.Data.InventarioDbContext _InventarioContext;
        public ArticuloServices(PruebaNetFramework.Data.InventarioDbContext InventarioContext)
        {
            _InventarioContext = InventarioContext;
        }
        public async Task<IHttpActionResult> Create(ArticuloViewModel model)
        {
            Articulo ArticuloEntity = new Articulo();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Content(HttpStatusCode.BadRequest, "Modelo no válido.");
                }
                
                ArticuloEntity.Sku_NumeroSerie = model.Sku_NumeroSerie;
                ArticuloEntity.Sku_Descripcion = model.Sku_Descripcion;
                ArticuloEntity.Sku_Cantidad = model.Sku_Cantidad;
                ArticuloEntity.Sku_Cat_ID = model.Sku_Cat_ID;
                ArticuloEntity.Sku_Sub_Cat_ID = model.Sku_Sub_Cat_ID;
                ArticuloEntity.Sku_Latitud = model.Sku_Latitud;
                ArticuloEntity.Sku_Longitud = model.Sku_Longitud;
                _InventarioContext.Articulo.Add(ArticuloEntity);
                await _InventarioContext.SaveChangesAsync();
                return Content(HttpStatusCode.Created, ArticuloEntity);

            }
            catch (ApplicationException ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex);
            }
            finally
            {
                ArticuloEntity = null;
                model = null;
            }
        }

        public async Task<IHttpActionResult> delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return Content(HttpStatusCode.BadRequest, "El identificador es nulo.");      
                }
                Articulo articuloEntity = await _InventarioContext.Articulo.FindAsync(id);
                if (articuloEntity == null)
                {
                    return Content(HttpStatusCode.NotFound, "Articulo no encontrado.");
                    
                }
                _InventarioContext.Articulo.Remove(articuloEntity);
                await _InventarioContext.SaveChangesAsync();
                return Content(HttpStatusCode.OK,"Elimado correctamente.");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex);
         
            }
        }

        public async Task<IHttpActionResult> GetAll()
        {
            List<Articulo> personaEntity = await _InventarioContext.Articulo.ToListAsync();
            List<ArticuloViewModel> personaViewModels = personaEntity.ConvertAll(x => new ArticuloViewModel(x));
            return Ok(personaViewModels);
        }

        public async Task<IHttpActionResult> GetById(int? id)
        {
            try
            {
                if (id == null)
                {
                    return Content(HttpStatusCode.BadRequest, "Identificador de articulo nulo.");
                }

                List<Articulo> articuloEntity = await _InventarioContext.Articulo.Where(x => x.Sku_ID.Equals(id)).ToListAsync();
                if (articuloEntity == null || articuloEntity.Count() == 0)
                {
                    return Content(HttpStatusCode.NotFound, "No se encontro el articulo.");
                }
                List<ArticuloViewModel> articuloViewList = articuloEntity.ConvertAll(x => new ArticuloViewModel(x));
                ArticuloViewModel articuloView = articuloViewList.FirstOrDefault();
                return Content(HttpStatusCode.OK, articuloView);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }

        public async Task<IHttpActionResult> Update(ArticuloViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Content(HttpStatusCode.BadRequest,"Modelo no válido.");
                }
                Articulo articuloEntity = await _InventarioContext.Articulo.FindAsync(model.Sku_ID);
                if (articuloEntity == null)
                {
                    return Content(HttpStatusCode.NotFound, "Articulo no encontrado.");
                }
                articuloEntity.Sku_ID = model.Sku_ID;
                articuloEntity.Sku_NumeroSerie = model.Sku_NumeroSerie;
                articuloEntity.Sku_Descripcion = model.Sku_Descripcion;
                articuloEntity.Sku_Cantidad = model.Sku_Cantidad;
                articuloEntity.Sku_Cat_ID = model.Sku_Cat_ID;
                articuloEntity.Sku_Sub_Cat_ID = model.Sku_Sub_Cat_ID;
                articuloEntity.Sku_Latitud = model.Sku_Latitud;
                articuloEntity.Sku_Longitud = model.Sku_Longitud;
                await _InventarioContext.SaveChangesAsync();
                return Content(HttpStatusCode.OK, articuloEntity);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}