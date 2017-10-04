using Fernando.OloloVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando.OloloVeiculos.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            this.Cliente = new Cliente
            {
                Email = "fernando_rw94@hotmail.com",
                Nome = "Fernando Ramos Wolff",
                Telefone = "4999177-2464"
            };
        }
        public Cliente Cliente { get; set; }

        public string Nome {
            get
            {
                return this.Cliente.Nome;
            }
            set
            {
                this.Cliente.Nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this.Cliente.Telefone;
            }
            set
            {
                this.Cliente.Telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return Cliente.Email;
            }
            set
            {
                this.Cliente.Email = value;
            }
        }
    }
}
