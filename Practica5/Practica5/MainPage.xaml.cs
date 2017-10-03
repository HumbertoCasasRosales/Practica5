using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void siguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Practica5.practica3());
        }
    }
}
