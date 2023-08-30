namespace Triangulo_equilátero;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(A.Text) && !string.IsNullOrEmpty(B.Text) && !string.IsNullOrEmpty(C.Text))
        {
          double a, b, c;
            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);
            c = Convert.ToDouble(C.Text);

            double suma;

            suma =(a+b+c)/2;
            sum.Text = suma.ToString();

            double Área;
            Área= Math.Sqrt(suma*(suma-a)*(suma-b)*(suma-c));
           
            resul.Text = Área.ToString("N2");
        }

        else
        {
            DisplayAlert("Error", "Ingresa todos los datos", "Ok");
        }

    }

    private void Limpiar_Clicked(object sender, EventArgs e)
    {
        sum.Text = " ";
        A.Text = " ";
        B.Text = " ";
        C.Text = " ";
        resul.Text = " ";

    }
}

