using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando.OloloVeiculos.Models
{
    public class Agendamento
    {
        public Veiculo Veiculo { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DateAgendamento { get; set; }
        public TimeSpan TimeAgendamento { get; set; }
    }
}
