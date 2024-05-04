namespace PollaFutbolera.Pages.Profile;

public partial class Profile : ContentPage
{
	private int number = 0;

	public Profile()
	{
		InitializeComponent();

    }

	private void NumberXd(object sender, EventArgs e)
	{
		number++;
		Console.WriteLine(number);
		Ff.Text = number.ToString();

		
	}

}