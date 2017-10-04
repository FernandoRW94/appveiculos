using System;
using System.Collections.Generic;
namespace Fernando.OloloVeiculos.Models
{
    public class Veiculo
    {
        public decimal AirBagPrice { get { return 2800; } }
        public decimal AbsPrice { get { return 4000; } }
        public decimal AirPrice { get { return 3500; } }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public bool HaveAirBag { get; set; }

        public bool HaveAir { get; set; }

        public bool HaveAbs { get; set; }

        public decimal OptionalsValue
        {
            get
            {
                return 0 + (HaveAirBag ? AirBagPrice : 0) + (HaveAir ? AirPrice : 0) + (HaveAbs ? AbsPrice : 0);
            }
        }

        public decimal TotalPrice { get { return Price + OptionalsValue; } }

        public Veiculo()
        {
            this.HaveAbs = false;
            this.HaveAir = false;
            this.HaveAirBag = false;
        }
    }
}
