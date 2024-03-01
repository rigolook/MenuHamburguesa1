using MenuHamburguesa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MenuHamburguesa.Simulacion
{
    public class Ventiladoressim
    {
        private MVentilador[] _Venti = new MVentilador[10];

        public int Cont = -1;
        private static Ventiladoressim _instanciaAtreglo;

        public static Ventiladoressim Instancia
        {
            get
            {
                if (_instanciaAtreglo == null)
                {
                    _instanciaAtreglo = new Ventiladoressim();
                }
                return _instanciaAtreglo;
            }
        }

        public void Insertar(MVentilador _manga)
        {
            Cont++;
            if (Cont>=9)
            new MVentilador { ID = $"{_manga.ID}", Habitacion = $"{_manga.Habitacion}", Rpm = $"{_manga.Rpm}", Encendido = _manga.Encendido };
        }

        public void Actualizardatos(MVentilador _ventilador)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (_Venti[i] != null && _Venti[i].ID == _ventilador.ID)
                {
                    _Venti[i] = _ventilador;
                    break;
                }
            }
        }

        public void EliminarDatos(string ID)
        {
            int Borarr = 0;
            for (int x = 0; x <= Cont; x++)
            {
                if (_Venti[x].ID == ID)
                {
                    _Venti[x] = null;
                    Borarr = x;
                    break;
                }
            }
            for (int x = Borarr; x <= Cont; x++)
            {
                _Venti[x] = _Venti[x + 1];
            }
            Cont--;
        }

        public MVentilador[] ObtenerAreglo()
        {
           
            return _Venti;
        }
    }
}