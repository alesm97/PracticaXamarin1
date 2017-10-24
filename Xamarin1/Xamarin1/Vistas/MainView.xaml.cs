using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        // Var counter initialize to 1
        int counter = 1;

        public MainView()
        {
            InitializeComponent();

            MyButton.Clicked += (sender, args) =>
            {
                //MyButton.Text = String.Format("{0} clicks",counter++);
                LblTimes.Text = String.Format("Botón pulsado {0} veces.", counter++);
            };
        }
    }
}