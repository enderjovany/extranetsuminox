using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class FormPost
    {
        [Key, Display(Name = "Forma"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdFormPost { get; set; }
        [Required, Display(Name = "Forma")]
        public string Form { get; set; }
    }
}