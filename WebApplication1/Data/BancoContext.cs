using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : 
            base(options)
        {
        }

        public DbSet<ExtratoAnaliticoCteModel> Extratos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          //  modelBuilder.Entity<ExtratoAnaliticoCteModel>().HasKey(e => e.chCTe_Proto);
            // outras configurações do modelo
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExtratoAnaliticoCteModel>().ToTable("InformacoesDadosDeCTe");
            // outras configurações do modelo
        }

    }
}
