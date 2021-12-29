using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcaLucros.Models
{
    public class Orcamentos : IDomainEntity
    {
        public Guid Id { get; set; }
        public string SaldoInicial  { get; set; }
        public string Entrada { get; set; }
        public DateTime DtEntrada{ get; set; }
        public string Saida { get; set; }
        public DateTime DtSaida{ get; set; }
        public string ValorFinal { get; set; }

        public Orcamentos() { }
    }
}
