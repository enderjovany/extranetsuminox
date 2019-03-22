using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class MaterialTypePost
    {
        [Key, Display(Name = "Tipo de Material"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdMaterialTypePost { get; set; }
        [Required, Display(Name = "Tipo de Material")]
        public string MaterialType { get; set; }
    }
}