using PollaFutbolera.Pages.Create;
using PollaFutbolera.Pages.Home;
using PollaFutbolera.Pages.Polla;
using PollaFutbolera.Pages.Profile;

namespace PollaFutbolera
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();

            //Routing.RegisterRoute("Home", typeof(Home));
            //Routing.RegisterRoute("Create", typeof(Create));
            //Routing.RegisterRoute("Profile", typeof(Profile));

            ////Children.Add(new Home() { Title = "Inicio", IconImageSource = "Resources/AppIcon/ic--sharp-home.svg" });
            ////Children.Add(new Create() { Title = "Crear", IconImageSource = "Resources/AppIcon/ic--sharp-plus.svg" });
            ////Children.Add(new Profile() { Title = "Perfil", IconImageSource = "Resources/AppIcon/carbon--user-avatar.svg" });
        }

        //private async void gotohome(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("Home");
        //    //await Navigation.PushModalAsync(new Notifications());
        //}
        //private async void gotocreate(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("Create");
        //    //await Navigation.PushModalAsync(new Notifications());
        //}
        //private async void gotoprofile(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("Profile");
        //    //await Navigation.PushModalAsync(new Notifications());
        //}

    }

}
