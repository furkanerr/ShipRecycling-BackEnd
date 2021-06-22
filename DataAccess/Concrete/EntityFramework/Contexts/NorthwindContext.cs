using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FURKAN\SQLEXPRESS;Database=GemiSökümProje;Trusted_Connection=true");
        }


        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        public DbSet<Bayraklar> Bayraklar { get; set; }
        public DbSet<Blok_MateryalIcerik> Blok_MateryalIcerik { get; set; }
        public DbSet<Bloklar> Bloklar { get; set; }

        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<Calisan_Meslekler> Calisan_Meslekler { get; set; }
        public DbSet<Denge> Denge { get; set; }

        public DbSet<GemiTipleri> GemiTipleri { get; set; }
        public DbSet<Gemiler> Gemiler { get; set; }
        public DbSet<HazMatTipi> HazMatTipi { get; set; }

        public DbSet<HazMat> HazMat { get; set; }
        public DbSet<IHMRapolari> IhmRapolari { get; set; }
        public DbSet<KaldirmaOperasyonalari> KaldirmaOperasyonalari { get; set; }

        public DbSet<KaldirmaOperasyonuPlanlari> KaldırmaOperasyonuPlanlari { get; set; }
        public DbSet<KazanDoldurmaOPerasyonlari> KazanDoldurmaOPerasyonlari { get; set; }
        public DbSet<KazanDoldurmaOperasyonlari_MateryalIcerikleri> KazanDoldurmaOperasyonlari_MateryalIcerikleri { get; set; }

        public DbSet<Kazanlar> Kazanlar { get; set; }
        public DbSet<Malzemeler> Malzemeler { get; set; }
        public DbSet<MateryalIcerikleri> MateryalIcerikleri { get; set; }

        public DbSet<Meslekler> Meslekler { get; set; }
        public DbSet<OlcuBirimi> OlcuBirimi { get; set; }
        public DbSet<ParaBirimleri> ParaBirimleri { get; set; }

        public DbSet<Resimler> Resimler { get; set; }
        public DbSet<Uygunmu> Uygunmu { get; set; }
        

    }
}
