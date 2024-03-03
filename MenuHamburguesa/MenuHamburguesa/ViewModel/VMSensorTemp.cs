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
    public class VMSensorTemp : BaseViewModel
    {
        #region variables
        public List<MSenTemp> _SensoresVentiladores;
        public SenTepsim _SenTep = SenTepsim.Instancia;//BORRAR
        #endregion

        public VMSensorTemp(INavigation naivigation)
        {
            Navigation = naivigation;

            ListarSenTemp();
  

        }

        #region Procesos
        public List<MSenTemp> Lista
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

        public void ListarSenTemp()
        {
            Lista = _SenTep.ObtenerAreglo();
        }


        public async Task IrSensoresGas()
        {

            await Navigation.PushAsync(new SenGaz());
        }

        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        #endregion
    }
}
