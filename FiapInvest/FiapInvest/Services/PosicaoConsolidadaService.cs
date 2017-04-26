using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapInvest.Services
{
    public class PosicaoConsolidadaService
    {
        public IList<PosicaoConsolidada> ConsultaPosicaoConsolidada(int idClienteConsulta)
        {
            IList<PosicaoConsolidada> lista = new List<PosicaoConsolidada>();
            var p1 = new PosicaoConsolidada
            {
                IdCliente = idClienteConsulta,
                IdFundo = 999991,
                NomeFundo = "Fundo IPCA Based",
                ValorInvestido = 12098.00,
                PercentualCarreira = 12,
                DataAtualizacao = DateTime.Now
            };

            lista.Add(p1);

            return lista;
        }
    }
}
