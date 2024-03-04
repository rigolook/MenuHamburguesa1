using MenuHamburguesa.Models;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MenuHamburguesa.Simulacion;
using System.Collections;

namespace MenuHamburguesa.ViewModel
{
    public class VMVentiladores : BaseViewModel
    {
        #region variables
        private List<MVentilador> _SensoresVentiladores;
       
      
        #endregion

        public VMVentiladores(INavigation navigation)
        {
            Navigation = navigation;
          
            ListarVentiladores();
        }

        #region Procesos
        public List<MVentilador> Lista
        {
            get { return _SensoresVentiladores; }
            set
            {
                SetValue(ref _SensoresVentiladores, value);
                OnpropertyChanged();

            }
        }
        #endregion
        #region Procesos

        public async Task IrSensoresGas()
        {
            await Navigation.PushAsync(new SenGaz());
        }
       
        public async Task ListarVentiladores()
        {
            var _VENTILADORES = Ventiladoressim.Instancia;//BORRAR
            Lista = _VENTILADORES.ObtenerAreglo();
        }
        public async Task IraEditar(MVentilador _modulo)
        {
            await Navigation.PushAsync(new EditarModulo(_modulo));
        }

        #endregion

        #region Comandos
        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        public ICommand IraEditarcommand => new Command<MVentilador>(async (p) => await IraEditar(p));
        #endregion

    }
}
