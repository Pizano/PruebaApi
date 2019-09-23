using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaNetFramework.EntityModels
{
    public class Articulo
    {
        [Key]
        public int Sku_ID { get; set; }
        public string Sku_NumeroSerie { get; set; }
        public string Sku_Descripcion { get; set; }
        public string Sku_Cantidad { get; set; }
        [ForeignKey("Categoria")]
        public int Sku_Cat_ID { get; set; }
        [ForeignKey("SubCategoria")]
        public int Sku_Sub_Cat_ID { get; set; }
        public string Sku_Latitud { get; set; }
        public string Sku_Longitud { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
    }
}