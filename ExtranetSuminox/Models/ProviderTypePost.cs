using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class ProviderTypePost
    {
        [Key, Display(Name = "Tipo de Proveedor"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdProviderTypePost { get; set; }
        [Required, Display(Name = "Tipo de Proveedor")]
        public string ProviderType { get; set; }
    }
}