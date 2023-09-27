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
            double n1 = double.Parse(numero1.Text);
            double n2 = double.Parse(numero2.Text);
            double res = n1 + n2;
            Navigation.PushAsync(new Resultado(res));
            ;
        }

        private void OnRestaClicked(object sender, EventArgs e)
        {
            double n1 = double.Parse(numero1.Text);
            double n2 = double.Parse(numero2.Text);
            double res = n1 - n2;
            Navigation.PushAsync(new Resultado(res));
        }

        private void OnMultiplicacionClicked(object sender, EventArgs e)
        {
            double n1 = double.Parse(numero1.Text);
            double n2 = double.Parse(numero2.Text);
            double res = n1 * n2;
            Navigation.PushAsync(new Resultado(res));
        }

        private void OnDivisionClicked(object sender, EventArgs e)
        {
            double n1 = double.Parse(numero1.Text);
            double n2 = double.Parse(numero2.Text);
            if (n2 != 0)
            {
                double res = n1 / n2;
                Navigation.PushAsync(new Resultado(res));
            }
            else
            {
                MostrarError("Error: División por cero.");
            }
        }

        private async void MostrarError(string mensaje)
        {
            await DisplayAlert("Error", mensaje, "OK");
        }
    }

}