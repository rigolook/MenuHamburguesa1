﻿using MenuHamburguesa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MenuHamburguesa.Simulacion
{
    public class Ventiladoressim
    {
        // private MVentilador[] _Venti=new MVentilador[11];
        private List<MVentilador> listaVenti=new List<MVentilador>();
        private int Cont = -1;
        private static Ventiladoressim _instanciaVentiladior;

        public static Ventiladoressim Instancia
        {
            get
            {
                if (_instanciaVentiladior == null)
                {
                    _instanciaVentiladior = new Ventiladoressim();
                }
                return _instanciaVentiladior;
            }
        }

        public bool Insertar(MVentilador _ventilador)
        {
            Cont++;

            if (Cont <= 9)
            {
                listaVenti.Add(_ventilador);
                return true;
            }
            else
                return false;


        }

        public void Actualizardatos(MVentilador _ventilador)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (listaVenti[i] != null && listaVenti[i].ID == _ventilador.ID)
                {
                    listaVenti[i] = _ventilador;
                    break;
                }
            }
        }

        public void EliminarDatos(string ID)
        {
            int Borarr = 0;
            for (int x = 0; x <= Cont; x++)
            {
                if (listaVenti[x].ID == ID)
                {
                    listaVenti[x] = null;
                    Borarr = x;
                    break;
                }
            }
            for (int x = Borarr; x <= Cont; x++)
            {
                listaVenti[x] = listaVenti[x + 1];
            }
            Cont--;
        }

        public List<MVentilador> ObtenerAreglo()
        {
           
            return listaVenti;
        }
    }
}