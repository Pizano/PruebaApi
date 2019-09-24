using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaNetFramework.EntityModels
{
    public class SubCategoria
    {
        [Key]
        public int SubCat_ID { get; set; }
        [ForeignKey("Categoria")]
        public int SubCat_Cat_ID { get; set; }
        public int SubCat_SubCatCodigo { get; set; }
        public string SubCat_Descripcion { get; set; }

        [Required]
        public virtual Categoria Categoria { get; set; }

    }
}