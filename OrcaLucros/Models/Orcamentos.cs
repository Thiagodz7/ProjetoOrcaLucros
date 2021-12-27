using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcaLucros.Models
{
    public class Orcamentos : IDomainEntity
    {
        public Guid Id { get; private set; }
        public float SaldoInicial  { get; private set; }
        public float Entrada { get; private set; }
        public DateTime Dt_Entrada{ get; private set; }
        public float Saida { get; private set; }
        public DateTime Dt_Saida{ get; private set; }
        public float ValorFinal { get; private set; }

        public Orcamentos() { }
    }
}
