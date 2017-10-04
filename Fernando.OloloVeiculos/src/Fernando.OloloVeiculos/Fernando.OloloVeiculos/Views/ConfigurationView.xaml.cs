using Fernando.OloloVeiculos.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fernando.OloloVeiculos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigurationView : ContentPage
    {
        public VeiculoViewModel Veiculo { get; set; }        
        
        public ConfigurationView(VeiculoViewModel veiculo)
        {
            InitializeComponent();

            this.Veiculo = veiculo;

            this.BindingContext = Veiculo;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormView(this.Veiculo));
        }
                
    }
}