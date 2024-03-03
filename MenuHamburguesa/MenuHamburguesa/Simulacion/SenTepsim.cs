using MenuHamburguesa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MenuHamburguesa.Simulacion
{
    public class SenTepsim
    {
        
        List<MSenTemp> listaTemp=new List<MSenTemp>();
        public int Cont = -1;
        private static SenTepsim _instanciaAtreglo;

        public static SenTepsim Instancia
        {
            get
            {
                if (_instanciaAtreglo == null)
                {
                    _instanciaAtreglo = new SenTepsim();
                }
                return _instanciaAtreglo;
            }
        }

        public bool Insertar(MSenTemp _Tem)
        {
            Cont++;

            if (Cont <= 9)
            {
                listaTemp.Add(_Tem);
                return true;
            }
            else
                return false;


        }

        public void Actualizardatos(MSenTemp _Tem)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (listaTemp[i] != null && listaTemp[i].ID == _Tem.ID)
                {
                    listaTemp[i] = _Tem;
                    break;
                }
            }
        }

        public void EliminarDatos(string ID)
        {
            int Borarr = 0;
            for (int x = 0; x <= Cont; x++)
            {
                if (listaTemp[x].ID == ID)
                {
                    listaTemp[x] = null;
                    Borarr = x;
                    break;
                }
            }
            for (int x = Borarr; x <= Cont; x++)
            {
                listaTemp[x] = listaTemp[x + 1];
            }
            Cont--;
        }

        public List<MSenTemp> ObtenerAreglo()
        {
           
            return listaTemp;
        }
    }
}