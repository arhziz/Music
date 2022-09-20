namespace Music.Views;

public partial class RadioPage : ContentPage
{
	public RadioPage()
	{
		InitializeComponent();
	}


    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if (currentTheme == AppTheme.Dark)
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Radio,
                FontFamily = "ICO",
                Color = Color.FromHex("#EFEFEF")
            };
        }
        else
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Radio,
                FontFamily = "ICO",
                Color = Color.FromHex("#1C1C1C")
            };
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (MusicStaticProperties.CurrentTabbedPage == 2)
        {


            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Radio,
                FontFamily = "ICO",
                Color = Color.FromHex("#f92d48")
            };

        }

    }
}