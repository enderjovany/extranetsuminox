using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class ProvidersPost
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdProvidersPost { get; set; }
        [Required, Display(Name = "Nombre de proveedor")]
        [StringLength(50)]
        public string ProviderNamePost { get; set; }
        [Required, Display(Name = "Tipo de proveedor")]
        public string IdProviderTypePost { get; set; }
        [Required, Display(Name = "Persona Contacto")]
        public string contact { get; set; }
        [Required, Display(Name = "Correo Electronico")]
        public string email { get; set; }
        [Required, Display(Name = "Tlf")]
        public string phone { get; set; }
        [Required, Display(Name = "Origen del material")]
        public string origin { get; set; }
        [Required, Display(Name = "Planta de procedencia")]
        public string plant { get; set; }
        [Required, Display(Name = "Posee ISO")]
        public bool certificate { get; set; }
        [Required, Display(Name = "Página Web")]
        public string web { get; set; }
        [Required, Display(Name = "Tipo de material")]
        public string IdMaterialTypePost { get; set; }
        [Required, Display(Name = "Forma")]
        public string IdFormPost { get; set; }
        [Required, Display(Name = "Acabado")]
        public string IdFinishPost { get; set; }
        public string IdRangeIniPost { get; set; }
        public string IdRangeFinPost { get; set; }
        public string IdPaymentPost { get; set; }

        public virtual ProviderTypePost ProviderType { get; set; }
        public virtual MaterialTypePost MaterialType { get; set; }
        public virtual FormPost Form { get; set; }
        public virtual FinishPost Finish { get; set; }
        public virtual RangeIniPost IniPost { get; set; }
        public virtual RangeFinPost FinPost { get; set; }
        public virtual PaymentPost Payment { get; set; }
    }
}