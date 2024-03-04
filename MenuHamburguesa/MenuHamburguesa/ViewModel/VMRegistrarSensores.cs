using MenuHamburguesa.Models;
using MenuHamburguesa.Models.Listados;
using MenuHamburguesa.Simulacion;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static Xamarin.Essentials.AppleSignInAuthenticator;

namespace MenuHamburguesa.ViewModel
{
    public class VMRegistrarSensores : BaseViewModel
    {
        #region variables
        public List<MPikerSensores> _ListaSensores { get; set;}
      
        public string _ID;
        public string _Habitacion;
        private MPikerSensores _selectedSensor = new MPikerSensores();
        
        //BORRAR de apartir de aqui despues del lunes
        public Ventiladoressim _VENTILADORES = Ventiladoressim.Instancia;
        public SenGazSim _SensorGaz = SenGazSim.Instancia;
        public SenTepsim _SensorTemperatura = SenTepsim.Instancia;
        private Random random = new Random();

        //aquillano
        #endregion
        #region consutructor
        public VMRegistrarSensores(INavigation naivigation)
        {
            Navigation = naivigation;
      
            _ListaSensores = GetLista();
          
        }
        #endregion

        #region Objetos
        public string ID
        {
            get { return _ID; }
            set { SetValue(ref _ID, value); }
        }
        public string Habitacion
        {
            get { return _Habitacion; }
            set { SetValue(ref _Habitacion, value); }
        }
     
        public MPikerSensores SelectedSensor
        {
            get {
               
                return _selectedSensor; }
            set { SetValue(ref _selectedSensor, value); }
        }

        #endregion
        #region pruebas 
        public List<MPikerSensores> GetLista()
        {
            var lista = new List<MPikerSensores>() 
            {
                new MPikerSensores(){Key= 1,Value="Ventilador" },
                new MPikerSensores(){Key= 2,Value="Gaz" },
                new MPikerSensores(){Key= 3,Value="Temperatura" },

            };
            
            return lista;
        }


        #endregion
        #region Procesos
        public void InsertarSensor()
        {
            switch (SelectedSensor.Value)
            {
                case "Ventilador":
                    {
                        MVentilador ventilador = new MVentilador();
                        ventilador.ID = ID;
                        ventilador.Habitacion = Habitacion;
                        ventilador.Rpm = (random.Next(699,3201)).ToString();//cambiar a 0
                        ventilador.Encendido = true;

                        if (_VENTILADORES.Insertar(ventilador))
                        {
                            DisplayAlert("Registro", $"Se registro el componente {SelectedSensor.Value}", "Aceptar");
                        }
                        else
                            DisplayAlert("Registro", "Registro fallido ser alcanzo el limite de resgistos de 10", "Aceptar");
                    }
                    break;
                case "Gaz":
                    {
                        MSenGaz _senGaz = new MSenGaz();
                        _senGaz.ID = ID;
                        _senGaz.Habitacion = Habitacion;
                        _senGaz.Gaz = "Co2";//cambiar a 0
                       

                        if (_SensorGaz.Insertar(_senGaz))
                        {
                            DisplayAlert("Registro", $"Se registro el sensor de {SelectedSensor.Value}", "Aceptar");
                        }
                        else
                            DisplayAlert("Registro", "Registro fallido ser alcanzo el limite de resgistos de 10", "Aceptar");
                    }
                    break;
                case "Temperatura":
                    {
                        MSenTemp _senTemp = new MSenTemp();
                        _senTemp.ID = ID;
                        _senTemp.Habitacion = Habitacion;
                        _senTemp.Humedad = (random.Next(10, 60)).ToString();//cambiar a 0
                        _senTemp.Temp = (random.Next(-19, 41)).ToString();

                        if (_SensorTemperatura.Insertar(_senTemp))
                        {
                            DisplayAlert("Registro", $"Se registro el sensor de {SelectedSensor.Value}", "Aceptar");
                        }
                        else
                            DisplayAlert("Registro", "Registro fallido ser alcanzo el limite de resgistos de 10", "Aceptar");
                        
                        
                    }
                    break;
                default:
                    DisplayAlert($"Error inesperado", $"A seleccionado que hiciste?", "Aceptar");
                    break;
            }
            Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        #endregion


        #region Comandos
        public ICommand InsertarSensorcommand => new Command(() => InsertarSensor());
        #endregion
    }
}
