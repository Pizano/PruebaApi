using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaNetFramework.EntityModels
{
    public class Categoria
    {
        [Key]
        public int Cat_ID { get; set; }
        public int Cat_CodCategoria { get; set; }
        public string Cat_Cat_Descripcion { get; set; }

        [Required]
        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
    }
}