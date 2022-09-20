using Microsoft.Maui.ApplicationModel;

namespace Music.Views;

public partial class SearchPage : ContentPage
{
    #region Members
    private double previousScrollPosition = 0;
    

    Color lineColor;

    BoxView theLine = new BoxView
    {
        HeightRequest = 1,
        VerticalOptions = LayoutOptions.End,
        Opacity = 0,


        Margin = new Thickness(0)
    };

    #endregion

    #region Constructor
   
    public SearchPage()
    {
        InitializeComponent();

        ModifyEntry();
        
        
        theLine.SetAppThemeColor(BackgroundColorProperty, Color.FromHex("#EFEFEF"), Color.FromHex("#1c1c1e"));
    }

    #endregion

    #region Methods
    void ModifyEntry()
    {
        EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif IOS
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
            handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;
#endif
        });
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if (currentTheme == AppTheme.Dark)
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Search,
                FontFamily = "ICO",
                Color = Color.FromHex("#EFEFEF")
            };
        }
        else
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Search,
                FontFamily = "ICO",
                Color = Color.FromHex("#1C1C1C")
            };
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if(MusicStaticProperties.CurrentTabbedPage == 4)
        {
            
            
                this.IconImageSource = new FontImageSource
                {
                    Glyph = IcoMoon.Search,
                    FontFamily = "ICO",
                    Color = Color.FromHex("#f92d48")
                };
            
        }

    }


    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        
        var theScroll = (ScrollView)sender;

        double labelDouble;

        if (theScroll.ScrollY > 53)
            SearchEntryClone.IsVisible = true;
        else
            SearchEntryClone.IsVisible = false;



        if (theScroll.ScrollY > 45)
            DisplayPageContents();
        else
            HidePageContents();
    }

    void ScrollToFadeConverter()
    {

    }

    double ScrollToDoubleConvert(double scrollInput, string dir)
    {
        double value;

        if (dir == "Up")
            value = titleLabel.TranslationY + (scrollInput / 20);
        else
            value = titleLabel.TranslationY - (scrollInput / 20);

        if (value >= 30)
            return (double)30;
        if (value <= 0)
            return 0;

        return value;

    }
    async void DisplayPageContents()
    {
        //Set Default State
        if(!MainGrid.Children.Contains(theLine))
            MainGrid.Add(theLine, 0, 0);


        

        _ = theLine.FadeTo(1, 250, Easing.Linear);
        
        _ = titleLabel.FadeTo(1, 100, Easing.SinIn);
       
    }

    async void HidePageContents()
    {
        _ = theLine.FadeTo(0, 250, Easing.Linear);
        await titleLabel.FadeTo(0, 100, Easing.SinOut);
        
    }

    #endregion


}