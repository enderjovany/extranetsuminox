using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class CertificatesPost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdProvidersPost { get; set; }
        [Required]
        [StringLength(20)]
        public string Factura { get; set; }
        [Required]
        [StringLength(20)]
        public string Oc { get; set; }
        [Required]
        [StringLength(20)]
        public string Colada { get; set; }
        [Required]
        [StringLength(200)]
        public string Calidad { get; set; }
        [Required, Display(Name = "País")]
        [StringLength(200)]
        public string IdPais { get; set; }
        public DateTime Publicacion { get; set; }
        [DataType(DataType.Upload)]
        public byte Certificado { get; set; }

        public virtual Pais Country{ get; set; }
        public virtual ProvidersPost ProviderNamePost { get; set; }
    }
}