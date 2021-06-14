using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Curso
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Range(0,999.99)]
        public decimal Precio { get; set; }

    }
}
