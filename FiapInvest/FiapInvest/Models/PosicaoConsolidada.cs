using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapInvest.Models
{
    public class PosicaoConsolidada
    {
        public DateTime DataAtualizacao { get; set; }
        public int IdCliente { get; set; }
        public int IdFundo { get; set; }
        public String NomeFundo { get; set; }
        public Double ValorInvestido { get; set; }
        public Double PercentualCarreira { get; set; }
        public String IconeFundo { get; set; }


    }
}
