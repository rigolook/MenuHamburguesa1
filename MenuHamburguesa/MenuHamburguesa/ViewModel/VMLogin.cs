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
    internal class VMLogin : BaseViewModel
    {
        #region Referencias
        string _nombre = string.Empty;
        //int _numero;
        string _password = string.Empty;
        bool _inicio;

        string _colorbtn = "#6699CC";
        #endregion
        public VMLogin(INavigation naivigation)
        {
            Navigation = naivigation;

        }  
        #region Objetos
        public string colorbtn
        {
            get { return _colorbtn; }
            set { SetValue(ref _colorbtn, value); }

        }
        public bool inicio
        {
            get { return _inicio; } set { SetValue(ref _inicio, value); } 
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
        //public int Numero
        //{
        //    get { return _numero; }
        //    set
        //    {
        //        _numero = value;
        //        OnPropertyChanged();
        //    }
        //}
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        #endregion
        private string _Mensaje;
       
        public string Mensaje
        {
            get { return _Mensaje; }
            set
            {
                _Mensaje = value;
                OnPropertyChanged();
            }
        }
        #region Procesos

        private async Task IniciarSecion()
        {
            
            if (Nombre != string.Empty && Password != string.Empty)
            {
                colorbtn = "Green";  
                await Task.Delay(200);
                colorbtn = "#6699CC";

                await Navigation.PushAsync(new MainPage());
                await DisplayAlert("Éxito", "La Sesión se inició exitosamente.", "Aceptar");
            }
            else
            {
                await DisplayAlert("Datos erróneos", "Llena todos los campos para iniciar Sesión.", "Aceptar");
            }
        }
        public void confirmar()
        {
            if (Nombre != string.Empty && Password != string.Empty)
            {
                inicio = true;
            }
            else
            {
               inicio= false;
            }
        }
        
        public async Task Registrar()
        {

            await Navigation.PushAsync(new Registrarte());
        }

        #endregion


        #region Comandos

        public ICommand Iniciarcommand => new Command(async () => await IniciarSecion());
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        #endregion
    }
}
