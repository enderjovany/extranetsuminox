using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class PaymentPost
    {
        [Key, Display(Name = "Condición de pago"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdPaymentPost { get; set; }
        [Required, Display(Name = "Condición de pago")]
        public string Payment { get; set; }
    }
}