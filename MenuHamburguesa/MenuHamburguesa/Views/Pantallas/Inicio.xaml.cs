using MenuHamburguesa.Views.Pantallas;
using MenuHamburguesa.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            UpdateData(); // Actualizar los datos al cargar la página

        }

        private void OnUpdateClicked(object sender, EventArgs e)
        {
            UpdateData(); // Actualizar los datos cuando se hace clic en el botón
        }

        private void UpdateData()
        {
            // Aquí deberías tener la lógica para obtener los datos de aire y temperatura
            // Puedes usar servicios web, sensores locales, etc.

            // Ejemplo: Obtener datos simulados
            double airQuality = GetAirQuality();
            double temperature = GetTemperature();

            // Actualizar los elementos de la interfaz de usuario
            airQualityLabel.Text = $"Calidad del aire: {airQuality}";
            temperatureLabel.Text = $"Temperatura: {temperature} °C";
        }

        // Métodos de ejemplo para obtener datos simulados
        private double GetAirQuality()
        {
            // Lógica para obtener la calidad del aire (puedes reemplazar con datos reales)
            return 80.5; // Ejemplo de calidad del aire
        }

        private double GetTemperature()
        {
            // Lógica para obtener la temperatura (puedes reemplazar con datos reales)
            return 25.3; // Ejemplo de temperatura
        }
    }
}