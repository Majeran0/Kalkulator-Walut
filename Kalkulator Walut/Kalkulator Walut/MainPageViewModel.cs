using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_Walut
{
    class MainPageViewModel : ViewModelBase
    {
        public IList<Waluta> Waluty { get { return WalutyData.Waluty; } }

        Waluta selectedWaluty;
        public Waluta SelectedWaluty {
            get { return selectedWaluty; }
            set {
                if(selectedWaluty != value)
                {
                    selectedWaluty = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
