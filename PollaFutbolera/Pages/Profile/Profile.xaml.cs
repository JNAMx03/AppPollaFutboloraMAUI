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

    private async void GoToFriends(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Friends");
        //await Navigation.PushAsync(new Notifications());
    }

}