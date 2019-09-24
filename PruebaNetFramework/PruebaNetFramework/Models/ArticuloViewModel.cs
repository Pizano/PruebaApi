using PruebaNetFramework.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PruebaNetFramework.Models
{
    public class ArticuloViewModel
    {

        public ArticuloViewModel()
        {
        }

        public ArticuloViewModel(Articulo x)
        {
            this.Sku_ID = x.Sku_ID;
            this.Sku_NumeroSerie = x.Sku_NumeroSerie;
            this.Sku_Descripcion = x.Sku_Descripcion;
            this.Sku_Cantidad = x.Sku_Cantidad;
            this.Sku_Cat_ID = x.Sku_Cat_ID;
            this.Sku_Sub_Cat_ID = x.Sku_Sub_Cat_ID;
            this.Sku_Latitud = x.Sku_Latitud;
            this.Sku_Longitud = x.Sku_Longitud;

        }

        public int Sku_ID { get; set; }
        public string Sku_NumeroSerie { get; set; }
        public string Sku_Descripcion { get; set; }
        public string Sku_Cantidad { get; set; }

        public int Sku_Cat_ID { get; set; }

        public int Sku_Sub_Cat_ID { get; set; }
        public string Sku_Latitud { get; set; }
        public string Sku_Longitud { get; set; }
    }
}