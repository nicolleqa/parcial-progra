using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace parcial.Models
{
    [Table("t_players")]
    public class Players
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es obligatorios.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Edad es obligatorios.")]
        public int? Edad { get; set; }
        public string? Posicion { get; set; }
    }
}