using AirePuro.View;
using MenuHamburguesa.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    internal class VMRegistrarse : BaseViewModel
    {
        #region Referencias
        string _nombre = string.Empty;
        //int _numero;
        string _password = string.Empty;
        string _confirmarP = string.Empty;
        int _numero;
        
        string _colorbtn = "#6699CC";
        #endregion
        public VMRegistrarse(INavigation naivigation)
        {
            Navigation = naivigation;
        }
        #region Objetos
        public string colorbtn
        {
            get { return _colorbtn; }
            set { SetValue(ref _colorbtn, value); }

        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }
        public int Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string ConfirmarP
        {
            get { return _confirmarP; }
            set
            {
                _confirmarP = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Procesos

        public async Task Registrar()
        {
            if (Nombre != string.Empty && Password != string.Empty && Numero != null && ConfirmarP != string.Empty)
            {
                colorbtn = "Green";  
                await Task.Delay(200);
                colorbtn = "#6699CC";

                await Navigation.PushAsync(new MainPage());
                await DisplayAlert("Éxito", "Haz creado una cuenta exitosamente.", "Aceptar");
            }
            else
            {
                await DisplayAlert("Datos erróneos", "Llena todos los campos para iniciar Sesión.", "Aceptar");
            }
        }

        #endregion


        #region Comandos

      
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        #endregion
    }
}
