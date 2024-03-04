using MenuHamburguesa.Models;
using MenuHamburguesa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa.Views.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarModulo : ContentPage
    {
        public EditarModulo(MVentilador ventilador)
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMEditarModulo(Navigation, ventilador);
        }
        public EditarModulo(MSenTemp senTemp )
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMEditarModulo(Navigation, senTemp);
        }
        public EditarModulo(MSenGaz senGaz)
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMEditarModulo(Navigation, senGaz);
        }

    }
}