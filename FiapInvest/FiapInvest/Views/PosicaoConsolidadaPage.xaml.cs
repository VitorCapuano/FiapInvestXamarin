using FiapInvest.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiapInvest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PosicaoConsolidadaPage : ContentPage
    {
        public PosicaoConsolidadaPage()
        {
            InitializeComponent();
            int idUsuario = 1;
            PosicaoConsolidadaBusiness business = new PosicaoConsolidadaBusiness();
            listViewPosicao.ItemsSource = business.ConsultarPosicaoConsolidada(idUsuario);
        }
    }
}
