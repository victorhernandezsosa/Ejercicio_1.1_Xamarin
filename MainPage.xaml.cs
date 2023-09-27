using Microsoft.Maui.Controls;

namespace Ejercicio_1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSumaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double n1) && double.TryParse(numero2.Text, out double n2)) { 

            double res = n1 + n2;
            Navigation.PushAsync(new Resultado(res));
            
            }
        }

        private void OnRestaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double n1) && double.TryParse(numero2.Text, out double n2))
            {

                double res = n1 - n2;
                Navigation.PushAsync(new Resultado(res));

            }
        }

        private void OnMultiplicacionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double n1) && double.TryParse(numero2.Text, out double n2))
            {

                double res = n1 * n2;
                Navigation.PushAsync(new Resultado(res));

            }
        }

        private void OnDivisionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double n1) && double.TryParse(numero2.Text, out double n2))
            {
                if (n2 != 0)
                {
                    double res = n1 / n2;
                    Navigation.PushAsync(new Resultado(res));
                }
                else
                {
                    MostrarError("Error: No se puede dividir con cero.");
                }
            }
            else
            {
                MostrarError("Error: Ingrese números válidos en ambas entradas.");
            }
        }

        private async void MostrarError(string mensaje)
        {
            await DisplayAlert("Error", mensaje, "OK");
        }
    }

}