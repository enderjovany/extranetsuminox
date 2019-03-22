using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExtranetSuminox.Models
{
    public class CertificatesContext: DbContext
    {
        public CertificatesContext()
            :base("DefaultConnection")
        {

        }
        public DbSet<CertificatesPost> CertificatesPosts { get; set; }
        public DbSet<Pais> Paises { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.ProvidersPost> ProvidersPosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.RangeFinPost> RangeFinPosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.FormPost> FormPosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.RangeIniPost> RangeIniPosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.MaterialTypePost> MaterialTypePosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.PaymentPost> PaymentPosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.ProviderTypePost> ProviderTypePosts { get; set; }

        public System.Data.Entity.DbSet<ExtranetSuminox.Models.FinishPost> FinishPosts { get; set; }
    }
}