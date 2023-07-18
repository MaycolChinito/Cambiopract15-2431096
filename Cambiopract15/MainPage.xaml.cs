namespace Cambiopract15;

//<Summary>
//<Createddate>15/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>16/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// Construí un programa en MAUI, tal que dado el costo de un articulo vendido y
// la cantidad de dinero entregada por el cliente, calcule e imprima el cambio que se debe entregar al mismo.
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Costo.Text) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            double articulo, dinero, vuelto;
            articulo = Convert.ToDouble(Costo.Text);
            dinero = Convert.ToDouble(Cantidad.Text);
            vuelto = dinero - articulo;
            Cambio.Text = Convert.ToString(vuelto);
        }
        else
        {
            DisplayAlert("Error", "Introduzca los datos solicitados", "Ok");
            Cambio.Text = "";
        }
    }
}

