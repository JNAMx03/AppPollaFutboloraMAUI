using PollaFutbolera.Pages.Home;
using PollaFutbolera.Pages.Polla;
using PollaFutbolera.Pages.Create;

using PollaFutbolera.Pages.Profile;

namespace PollaFutbolera
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Notification", typeof(Notifications));
            Routing.RegisterRoute("Polla", typeof(Polla));
            Routing.RegisterRoute("Details", typeof(Details));

            Routing.RegisterRoute("Friends", typeof(Friends));
        }
    }
}
