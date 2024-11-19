namespace IntroQ42024.Pages;

public partial class Pestana1 : ContentPage
{
	public Pestana1()
	{
		InitializeComponent();
	}

    private void btnSumar_Clicked(object sender, EventArgs e)
    {
        if (N1.Text == null || N1.Text == "")
        {
            Alerta("Ingrese valor del primer número");
        }
        else if (N2.Text == null || N2.Text == "")
        {
            Alerta("Ingrese valor del segundo número");
        }
        else
        {
            double n1, n2, suma;

            n1 = Double.Parse(N1.Text);
            n2 = Double.Parse(N2.Text);

            suma = n1 + n2;
            Resultado.Text = $"La suma es: {suma}";
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        N1.Text = "";
        N2.Text = "";
        Resultado.Text = "";
    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }
}