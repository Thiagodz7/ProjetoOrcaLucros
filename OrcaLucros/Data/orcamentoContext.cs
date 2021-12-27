using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrcaLucros.Models;
using OrcaLucros.Mappings;

namespace OrcaLucros.Data
{
    public class orcamentoContext : DbContext
    {
        public orcamentoContext(DbContextOptions<orcamentoContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrcamentosMap());
  
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Orcamentos> Orcamentos { get; set; }

    }
}
