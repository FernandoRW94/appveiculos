using Fernando.OloloVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando.OloloVeiculos.ViewModels
{
    public class AgendamentoViewModel
    {
        public AgendamentoViewModel(VeiculoViewModel veiculo)
        {
            this.Cliente = new ClienteViewModel();
            this.Veiculo = veiculo;
            this.Agendamento = new Agendamento
            {
                DateAgendamento = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                TimeAgendamento = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
            };
            
        }

        public ClienteViewModel Cliente { get; set; }

        public VeiculoViewModel Veiculo { get; set; }

        public Agendamento Agendamento { get; set; }

        public DateTime DateAgendamento
        {
            get
            {
                return this.Agendamento.DateAgendamento;
            }
            set
            {
                this.Agendamento.DateAgendamento = value;
            }
        }

        public TimeSpan TimeAgendamento
        {
            get
            {
                return this.Agendamento.TimeAgendamento;
            }
            set
            {
                this.Agendamento.TimeAgendamento = value;
            }
        }
    }
}
