using Fernando.OloloVeiculos.Models;
using System.ComponentModel;
using System.Globalization;

namespace Fernando.OloloVeiculos.ViewModels
{
    public class VeiculoViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }

        public string FormatedPrice { get { return this.Veiculo.Price.ToString("C", CultureInfo.CurrentCulture); } }

        public string FormatedName { get { return string.Format(this.Veiculo.Model + " " + this.Veiculo.Name); } }

        public string OptionalsPrice { get { return Veiculo.OptionalsValue.ToString("C", CultureInfo.CurrentCulture); } }

        public string TotalPrice { get { return Veiculo.TotalPrice.ToString("C", CultureInfo.CurrentCulture); } }
        
        public string AirBagText { get { return string.Format("Air Bag - {0}", Veiculo.AirBagPrice.ToString("C",CultureInfo.CurrentCulture)); } }
        public string ABSText { get { return string.Format("Freios ABS - {0}", Veiculo.AbsPrice.ToString("C", CultureInfo.CurrentCulture)); } }
        public string AirText { get { return string.Format("Ar Condicionado - {0}", Veiculo.AirPrice.ToString("C", CultureInfo.CurrentCulture)); } }

        public bool AirBag
        {
            get
            {
                return Veiculo.HaveAirBag;
            }
            set
            {
                Veiculo.HaveAirBag = value;
                OnPropertyChanged("OptionalsPrice");
                OnPropertyChanged("TotalPrice");
            }
        }

        public bool AirCond
        {
            get
            {
                return Veiculo.HaveAir;
            }
            set
            {
                Veiculo.HaveAir = value;
                OnPropertyChanged("OptionalsPrice");
                OnPropertyChanged("TotalPrice");
            }
        }

        public bool Abs
        {
            get
            {
                return Veiculo.HaveAbs;
            }
            set
            {
                Veiculo.HaveAbs = value;
                OnPropertyChanged("OptionalsPrice");
                OnPropertyChanged("TotalPrice");
            }
        }

        public VeiculoViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
