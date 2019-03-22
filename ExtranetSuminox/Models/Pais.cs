using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class Pais
    {
        [Key, Required, Display(Name = "País"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdPais { get; set; }
        [Required, Display(Name = "País"), StringLength(50)]
        public string Country { get; set; }
    }
}