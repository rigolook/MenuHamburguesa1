using MenuHamburguesa.Models;
using MenuHamburguesa.Simulacion;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    public class VMSenGaz : BaseViewModel
    {
        #region variables
        public List<MSenGaz> _SensoresGaz;
        private SenGazSim _SenGaz = SenGazSim.Instancia;//BORRAR
        #endregion

        public VMSenGaz(INavigation naivigation)
        {
            Navigation = naivigation;

            ListarSenGaz();
            ///Esto se quitara despues 

        }

        #region Procesos
        public List<MSenGaz> Lista
        {
            get { return _SensoresGaz; }
            set
            {
                SetValue(ref _SensoresGaz, value);
                OnpropertyChanged();

            }
        }
        #endregion
        #region Procesos



        public async Task IrSensoresGas()
        {

            await Navigation.PushAsync(new SenGaz());
        }

        public void ListarSenGaz()
        {
            Lista = _SenGaz.ObtenerAreglo();
        }
        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        #endregion
    }
}
