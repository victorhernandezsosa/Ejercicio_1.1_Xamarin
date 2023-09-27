namespace Ejercicio_1._1;

public partial class Resultado : ContentPage
{
	public Resultado(double respuesta)
	{
		InitializeComponent();
		result.Text = $"El Resultado es: {respuesta}";
	}
}