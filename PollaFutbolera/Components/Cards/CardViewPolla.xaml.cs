namespace PollaFutbolera.Components.Cards;

public partial class CardViewPolla : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardViewPolla), string.Empty);
    public static readonly BindableProperty CardPositionProperty = BindableProperty.Create(nameof(CardPosition), typeof(string), typeof(CardViewPolla), string.Empty);
    public static readonly BindableProperty CardNextProperty = BindableProperty.Create(nameof(CardNext), typeof(string), typeof(CardViewPolla), string.Empty);
    public static readonly BindableProperty CardLogoProperty = BindableProperty.Create(nameof(CardLogo), typeof(string), typeof(CardViewPolla), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardViewPolla.CardTitleProperty);
        set => SetValue(CardViewPolla.CardTitleProperty, value);
    }
    public string CardPosition
    {
        get => (string)GetValue(CardViewPolla.CardPositionProperty);
        set => SetValue(CardViewPolla.CardPositionProperty, value);
    }
    public string CardNext
    {
        get => (string)GetValue(CardViewPolla.CardNextProperty);
        set => SetValue(CardViewPolla.CardNextProperty, value);
    }
    public string CardLogo
    {
        get => (string)GetValue(CardViewPolla.CardLogoProperty);
        set => SetValue(CardViewPolla.CardLogoProperty, value);
    }

    public CardViewPolla()
	{
		InitializeComponent();
	}

    private async void GoToPolla(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Polla");
        //await Navigation.PushAsync(new Notifications());
    }
}