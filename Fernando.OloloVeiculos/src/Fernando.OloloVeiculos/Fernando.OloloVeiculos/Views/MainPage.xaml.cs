using Fernando.OloloVeiculos.Models;
using Fernando.OloloVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fernando.OloloVeiculos.Views
{
    public partial class MainPage : ContentPage
    {
        public List<VeiculoViewModel> Veiculos { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Veiculos = new List<VeiculoViewModel>
            {
                new VeiculoViewModel(new Veiculo(){Model="Fiat", Name="Palio", Price=30000}),
                new VeiculoViewModel(new Veiculo(){Model="Chevrolet", Name="Onix", Price=40000}),
                new VeiculoViewModel(new Veiculo(){Model="Volkswagen", Name="Gol", Price=36000}),
                new VeiculoViewModel(new Veiculo(){Model="Renault", Name="Clio",Price=29000}),
                new VeiculoViewModel(new Veiculo(){Model="Ford", Name="Cldasdsaio",Price=76000}),
                new VeiculoViewModel(new Veiculo(){Model="Mitsubish", Name="Clfsdfio",Price=53000}),
                new VeiculoViewModel(new Veiculo(){Model="olotr", Name="Cldasdasio",Price=35000}),
                new VeiculoViewModel(new Veiculo(){Model="gdfgdfg", Name="afsdgd",Price=87000}),
                new VeiculoViewModel(new Veiculo(){Model="rjyghg", Name="jghjgh",Price=54000}),
                new VeiculoViewModel(new Veiculo(){Model="fsdfsd", Name="Cljjghio",Price=43000}),
                new VeiculoViewModel(new Veiculo(){Model="fsdf", Name="jghjhg",Price=12000}),
                new VeiculoViewModel(new Veiculo(){Model="asdas", Name="oiuoiu",Price=65000}),
                new VeiculoViewModel(new Veiculo(){Model="gdbgf", Name="eqwewq",Price=54000}),
                new VeiculoViewModel(new Veiculo(){Model="nfnfgngf", Name="yrty",Price=34000}),
                new VeiculoViewModel(new Veiculo(){Model="nfgnfd", Name="rtyrt",Price=65000}),
                new VeiculoViewModel(new Veiculo(){Model="kijkij", Name="rwerwe",Price=53000}),
                new VeiculoViewModel(new Veiculo(){Model="Renault", Name="Clio",Price=29000}),
            };

            this.BindingContext = this;
        }

        private void ListVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ConfigurationView((VeiculoViewModel)e.Item));
            ListVeiculos.SelectedItem = null;
        }
    }
}
