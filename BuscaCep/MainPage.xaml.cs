using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaCep.Servicos;
//using BuscaCep.Servicos.Modelo;
using Xamarin.Forms;

namespace BuscaCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BuscaCep(object sender, EventArgs args)
        {
            Endereco end = ServicosViaCep.BuscaEnderecoCep(CEP.Text.Trim());

            Resultado.Text = String.Format("Endereço: {0} de {1}, {2} - {3}. {4}",
                end.logradouro, end.bairro,end.localidade,end.uf,end.cep);
            CEP.Text = "";
        }
    }
}
