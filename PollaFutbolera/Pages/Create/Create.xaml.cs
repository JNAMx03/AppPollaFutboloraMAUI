namespace PollaFutbolera.Pages.Create;

public partial class Create : ContentPage
{
	public Create()
	{
		InitializeComponent();
	}

	private async void GoToDetails(object sender, EventArgs e)
	{
		string name = Name.Text;
		string league = League.Text;
		string users = Users.Text;

		var PollaData = new Details()
		{
			PName = name,
			PLeague = league,
			PUsers = users
		};

        //await Shell.Current.GoToAsync("Details");
        await Navigation.PushAsync(PollaData);
    }
}