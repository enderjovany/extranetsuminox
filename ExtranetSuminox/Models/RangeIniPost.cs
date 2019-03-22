using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class RangeIniPost
    {
        [Key, Display(Name = "Rango minimo de medida"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdRangeIniPost { get; set; }
        [Required, Display(Name = "Rango minimo de medida")]
        public string RangeIni { get; set; }
    }
}