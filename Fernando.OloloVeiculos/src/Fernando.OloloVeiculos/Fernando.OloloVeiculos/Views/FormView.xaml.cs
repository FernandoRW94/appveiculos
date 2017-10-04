using Fernando.OloloVeiculos.Models;
using Fernando.OloloVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fernando.OloloVeiculos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormView : ContentPage
    {
        public AgendamentoViewModel Agendamento { get; set; }

        public FormView(VeiculoViewModel veiculo)
        {
            InitializeComponent();

            if(this.Agendamento == null) { this.Agendamento = new AgendamentoViewModel(veiculo); }

            this.BindingContext = Agendamento;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ////Salva o agendamento.
            //this.Agendamento.Agendamento = new Agendamento
            //{
            //    DateAgendamento = this.Agendamento.DateAgendamento,
            //    TimeAgendamento = this.Agendamento.TimeAgendamento,
            //    Cliente = this.Agendamento.Cliente.Cliente,
            //    Veiculo = this.Agendamento.Veiculo.Veiculo
            //};
        }
    }
}