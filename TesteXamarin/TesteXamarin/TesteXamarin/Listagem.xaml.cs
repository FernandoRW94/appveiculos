using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();

            lista.ItemsSource = new List<Veiculo>() {
                new Veiculo(){
                    Fabricante = "Chevrolet",
                    Modelo = "Celta",
                    Valor = 30000
                },
                new Veiculo(){
                    Fabricante = "Fiat",
                    Modelo = "Palio",
                    Valor = 36000
                },
                new Veiculo(){
                    Fabricante = "Ford",
                    Modelo = "Ecosport",
                    Valor = 58000
                },
                new Veiculo(){
                    Fabricante = "Ford",
                    Modelo = "Fusion",
                    Valor = 96000
                }
            };
        }

        private void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new Detalhes((Veiculo)e.Item));
        }

    }
}