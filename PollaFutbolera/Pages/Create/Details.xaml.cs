using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace PollaFutbolera.Pages.Create;

public partial class Details : ContentPage
{
	public string? PName { get; set; }
	public string? PLeague { get; set; }
	public string? PUsers { get; set; }

	public Details()
	{
		InitializeComponent();

	}


    private void GoToFinish(object sender, EventArgs e)
	{
		string rule1 = Rule1.Text;
		string comodin = Como.Text;
		string cost = Cost.Text;

		DisplayAlert("Resumen", $"Nombre: {PName}\nLiga: {PLeague}\nCantidad usuarios: {PUsers}\nRegla 1: {rule1}\nComodines?: {comodin}\nCosto: {cost}\n", "ok");
	}
}