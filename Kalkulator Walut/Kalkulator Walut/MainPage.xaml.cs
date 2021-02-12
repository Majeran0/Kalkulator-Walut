using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kalkulator_Walut
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double inp = double.Parse(input.Text);
            double rat = double.Parse(selected.Text);
            double total = 0;

            total = inp * rat;

            result.Text = total.ToString() + " PLN";
        }
    }
}
