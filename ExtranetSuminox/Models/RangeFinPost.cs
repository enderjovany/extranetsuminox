using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class RangeFinPost
    {
        [Key, Display(Name = "Rango máximo de medida") , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdRangeFinPost { get; set; }
        [Required, Display(Name = "Rango máximo de medida")]
        public string RangeFin { get; set; }
    }
}