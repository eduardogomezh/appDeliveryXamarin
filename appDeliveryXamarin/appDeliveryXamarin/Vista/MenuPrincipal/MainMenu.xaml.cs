using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appDeliveryXamarin.VistaModelo;

namespace appDeliveryXamarin.Vista.MenuPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            BindingContext = new VMmainMenu(Navigation);
        }
    }
}