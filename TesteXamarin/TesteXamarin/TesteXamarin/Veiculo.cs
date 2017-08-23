using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXamarin
{
    public class Veiculo
    {
        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        public decimal Valor { get; set; }

        public string Descricao
        {
            get
            {
                return string.Format($"{Fabricante} {Modelo}");
            }
        }

        public string ValorFormatado {
            get {
                return string.Format($"R$ {Valor}");
            }
        }
    }
}
