using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class FinishPost
    {
        [Key, Display(Name = "Acabado"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdFinishPost { get; set; }
        [Required, Display(Name = "Acabado")]
        public string Finish { get; set; }
    }
}