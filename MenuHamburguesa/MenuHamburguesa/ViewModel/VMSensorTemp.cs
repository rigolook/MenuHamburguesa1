﻿using MenuHamburguesa.Models;
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

        public async Task ListarSenTemp()
        {
            var _SenTep = SenTepsim.Instancia;//BORRAR
            Lista = _SenTep.ObtenerAreglo();
        }


        public async Task IrSensoresGas()
        {

            await Navigation.PushAsync(new SenGaz());
        }
        public async Task IraEditar(MSenTemp _modulo)
        {
            await Navigation.PushAsync(new EditarModulo(_modulo));
        }

        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        public ICommand IraEditarcommand => new Command<MSenTemp>(async (p) => await IraEditar(p));
        #endregion
    }
}
