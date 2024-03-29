﻿using MenuHamburguesa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MenuHamburguesa.Simulacion
{
    public class SenGazSim
    {
        // private MVentilador[] _Venti=new MVentilador[11];
        private List<MSenGaz> listaGaz=new List<MSenGaz>();
        private int Cont = -1;
        private static SenGazSim _instanciaGaz;

        public static SenGazSim Instancia
        {
            get
            {
                if (_instanciaGaz == null)
                {
                    _instanciaGaz = new SenGazSim();
                }
                return _instanciaGaz;
            }
        }

        public bool Insertar(MSenGaz _ventilador)
        {
            Cont++;

            if (Cont <= 9)
            {
                listaGaz.Add(_ventilador);
                return true;
            }
            else
                return false;


        }

        public void Actualizardatos(MSenGaz _ventilador)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (listaGaz[i] != null && listaGaz[i].ID == _ventilador.ID)
                {
                    listaGaz[i] = _ventilador;
                    break;
                }
            }
        }

        public bool EliminarDatos(string ID)
        {
            for (int x = 0; x <= Cont; x++)
            {
                if (listaGaz[x].ID == ID)
                {
                    listaGaz.RemoveAt(x);
                    Cont--;
                    return true;
                }
            }
            return false;
        }

        public List<MSenGaz> ObtenerAreglo()
        {
           
            return listaGaz;
        }
    }
}