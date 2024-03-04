using MenuHamburguesa.Models.Listados;
using MenuHamburguesa.Models;
using MenuHamburguesa.Simulacion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MenuHamburguesa.Views.Pantallas;
using System.Linq;
using System.Collections;
using MenuHamburguesa.Views;

namespace MenuHamburguesa.ViewModel
{
    public class VMEditarModulo : BaseViewModel
    {
        #region variables
        public List<MPikerSensores> _ListaSensores { get; set; }
        public string _ElimnacionComponente;
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
        #region consutructores
        public VMEditarModulo(INavigation navigation, MVentilador _Modulo)
        {
            Navigation = navigation;
            _ListaSensores = GetLista();
            ID = _Modulo.ID;
            Habitacion = _Modulo.Habitacion;
            SelectedSensor = _ListaSensores.FirstOrDefault(s => s.Value == "Ventilador");
            _ElimnacionComponente = "Ventilador";
        }
        public VMEditarModulo(INavigation navigation, MSenGaz _Modulo)
        {
            Navigation = navigation;
            _ListaSensores = GetLista();
            ID = _Modulo.ID;
            Habitacion = _Modulo.Habitacion;
            SelectedSensor = _ListaSensores?.FirstOrDefault(s => s.Value == "Gaz");
            _ElimnacionComponente = "Gaz";
        }
        public VMEditarModulo(INavigation navigation, MSenTemp _Modulo)
        {
            Navigation = navigation;
            _ListaSensores = GetLista();
            ID = _Modulo.ID;
            Habitacion = _Modulo.Habitacion;
            SelectedSensor = _ListaSensores?.FirstOrDefault(s => s.Value == "Temperatura");
            _ElimnacionComponente = "Temperatura";
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
            get { return _selectedSensor; }
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
                new MPikerSensores(){Key= 3,Value="Temperatura" }
            };

            return lista;
        }
        #endregion
        #region Procesos
        public void Editar()
        {
            Random random = new Random();
            MVentilador ventilador = new MVentilador();
            MSenGaz sengaz= new MSenGaz();
            MSenTemp senTemp= new MSenTemp();
            if (_ElimnacionComponente == "Ventilador")
            {
                switch (SelectedSensor.Value)
                {
                    case "Ventilador":
                        {
                            ventilador.ID=ID;
                            ventilador.Habitacion = Habitacion;
                            ventilador.Encendido = true;
                            ventilador.Rpm=(random.Next(699, 3201)).ToString();
                            _VENTILADORES.Actualizardatos(ventilador);
                        }
                        break;
                    case "Gaz":
                        {
                            sengaz.ID=ID;
                            sengaz.Habitacion=Habitacion;
                            sengaz.Gaz = "Aire puro";
                            _SensorGaz.Insertar(sengaz);
                            _VENTILADORES.EliminarDatos(ID);
                        }
                        break;
                    case "Temperatura":
                        {
                            senTemp.ID=ID;
                            senTemp.Habitacion=Habitacion;
                            senTemp.Humedad = (random.Next(10, 60)).ToString();//cambiar a 0
                            senTemp.Temp = (random.Next(-19, 41)).ToString();
                            _SensorTemperatura.Insertar(senTemp);
                            _VENTILADORES.EliminarDatos(ID);
                        }
                        break;
                    default:
                        {
                            DisplayAlert($"Error inesperado", $"Algo sali mal", "Aceptar");
                        }
                        break;
                }
            }
            else if (_ElimnacionComponente == "Gaz")
            { 
                switch (SelectedSensor.Value)
                {
                    case "Ventilador":
                        {
                            ventilador.ID = ID;
                            ventilador.Habitacion = Habitacion;
                            ventilador.Rpm = (random.Next(699, 3201)).ToString();//cambiar a 0
                            ventilador.Encendido = true;
                            _VENTILADORES.Insertar(ventilador);
                            _SensorGaz.EliminarDatos(ID);
                        }
                        break;
                    case "Gaz":
                        {
                            sengaz.ID = ID;
                            sengaz.Habitacion = Habitacion;
                            sengaz.Gaz = "Aire puro";
                            _SensorGaz.Actualizardatos(sengaz);
                        }
                        break;
                    case "Temperatura":
                        {
                            senTemp.ID = ID;
                            senTemp.Habitacion = Habitacion;
                            senTemp.Humedad = (random.Next(10, 60)).ToString();//cambiar a 0
                            senTemp.Temp = (random.Next(-19, 41)).ToString();
                            _SensorTemperatura.Insertar(senTemp);
                            _SensorGaz.EliminarDatos(ID);
                        }
                        break;
                    default:
                        {
                            DisplayAlert($"Error inesperado", $"Algo sali mal", "Aceptar");
                        }
                        break;
                }
            }
            else if (_ElimnacionComponente == "Temperatura")
            {
                switch (SelectedSensor.Value)
                {
                    case "Ventilador":
                        {
                            ventilador.ID = ID;
                            ventilador.Habitacion = Habitacion;
                            ventilador.Rpm = (random.Next(699, 3201)).ToString();//cambiar a 0
                            ventilador.Encendido = true;
                            _VENTILADORES.Insertar(ventilador);
                            _SensorTemperatura.EliminarDatos(ID);
                        }
                        break;
                    case "Gaz":
                        {
                            sengaz.ID = ID;
                            sengaz.Habitacion = Habitacion;
                            sengaz.Gaz = "Aire puro";
                            _SensorGaz.Insertar(sengaz);
                            _SensorTemperatura.EliminarDatos(ID);
                        }
                        break;
                    case "Temperatura":
                        {
                            senTemp.ID = ID;
                            senTemp.Habitacion = Habitacion;
                            senTemp.Humedad = (random.Next(10, 60)).ToString();//cambiar a 0
                            senTemp.Temp = (random.Next(-19, 41)).ToString();
                            _SensorTemperatura.Actualizardatos(senTemp);
                        }
                        break;
                    default:
                        {
                            DisplayAlert($"Error inesperado", $"Algo sali mal", "Aceptar");
                        }
                        break;
                }
            }
            Volver();
        }

        public void Eliminar()
        {
            switch (_ElimnacionComponente)
            {
                case "Ventilador"://VENTILADORES
                    {

                        if (_VENTILADORES.EliminarDatos(ID))
                        {
                            DisplayAlert("Eliminado", $"Se a Eliminado el componente {_ElimnacionComponente}", "Aceptar");
                            
                        }
                        else
                            DisplayAlert("Eliminado", "Eliminado fallida", "Aceptar");
                    }
                    break;
                case "Gaz":
                    {
                        if (_SensorGaz.EliminarDatos(ID))
                        {
                            DisplayAlert("Eliminado", $"Se a Eliminado el sensor de {_ElimnacionComponente}", "Aceptar");

                        }
                        else
                            DisplayAlert("Eliminado", "Eliminado fallida", "Aceptar");
                    }
                    break;
                case "Temperatura":
                    {
                        if (_SensorTemperatura.EliminarDatos(ID))
                        {
                            DisplayAlert("Eliminado", $"Se a Eliminado el sensor de {_ElimnacionComponente}", "Aceptar");
                        }
                        else
                            DisplayAlert("Eliminado", "Eliminado fallida", "Aceptar");


                    }
                    break;
                default:
                    DisplayAlert($"Error inesperado", "As Eliminado... espera  ¿que hiciste?", "No c");
                    break;
            }
            Volver();
        }

        public async Task Volver()
        {
            await Navigation.PushAsync(new Monitoreo());
        }
        #endregion

       
        #region Comandos
        public ICommand EditarModuloSensorcommand => new Command(() => Editar());
        public ICommand EliminarModuloSensorcommand => new Command(() => Eliminar());

        #endregion
    }
}