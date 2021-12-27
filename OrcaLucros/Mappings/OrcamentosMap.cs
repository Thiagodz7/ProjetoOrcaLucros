using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrcaLucros.Models;

namespace OrcaLucros.Mappings
{
    public class OrcamentosMap : IEntityTypeConfiguration<Orcamentos>
    {
        public void Configure(EntityTypeBuilder<Orcamentos> builder)
        {
            
            builder.ToTable("Orcamentos", "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder.Property(x => x.SaldoInicial)
                .HasColumnName("SaldoInicial")
                .IsRequired();
            builder.Property(x => x.Entrada)
                .HasColumnName("Entrada")
                .IsRequired();
            builder.Property(x => x.Dt_Entrada)
                .HasColumnName("DtEntrada")
                .IsRequired();
            builder.Property(x => x.Saida)
                .HasColumnName("Saida")
                .IsRequired();
            builder.Property(x => x.Dt_Saida)
                .HasColumnName("DtSaida")
                .IsRequired();
            builder.Property(x => x.ValorFinal)
                .HasColumnName("ValorFinal")
                .IsRequired();
        }
    }
}
