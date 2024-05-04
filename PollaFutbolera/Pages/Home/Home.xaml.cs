using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace PollaFutbolera.Pages.Home;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

        //BackgroundColor = Colors.Blue;

    }

	private async void GoToNotification(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("Notification");
        //await Navigation.PushAsync(new Notifications());
    }
    private async void GoToPolla(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Polla");
        //await Navigation.PushAsync(new Notifications());
    }

}