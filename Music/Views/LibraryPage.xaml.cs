namespace Music.Views;

public partial class LibraryPage : ContentPage
{
    #region Members
    private LibraryItems previouslySeletedItem;
    Color lineColor;

    BoxView theLine = new BoxView
    {
        HeightRequest = 1,
        VerticalOptions = LayoutOptions.End,
        Opacity = 0,


        Margin = new Thickness(0)
    };
    #endregion

    #region Constructors
    
    public LibraryPage()
    {
        InitializeComponent();
        

        theLine.SetAppThemeColor(BackgroundColorProperty, Color.FromHex("#EFEFEF"), Color.FromHex("#1c1c1e"));
    }
    #endregion

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        //var statusBarColor = Color.FromRgb(BindingContext.RedSliderValue, BindingContext.GreenSliderValue, BindingContext.BlueSliderValue);
        //CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(statusBarColor);
    }


    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if (currentTheme == AppTheme.Dark)
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Folders,
                FontFamily = "ICO",
                Color = Color.FromHex("#EFEFEF")
            };
        }
        else
        {
            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Folders,
                FontFamily = "ICO",
                Color = Color.FromHex("#1C1C1C")
            };
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (MusicStaticProperties.CurrentTabbedPage == 3)
        {


            this.IconImageSource = new FontImageSource
            {
                Glyph = IcoMoon.Folders,
                FontFamily = "ICO",
                Color = Color.FromHex("#f92d48")
            };

        }

    }

    #region Methods
    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {

        var theScroll = (ScrollView)sender;

        double labelDouble;

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
        if (!MainGrid.Children.Contains(theLine))
            MainGrid.Add(theLine, 0, 0);




        _ = theLine.FadeTo(1, 250, Easing.Linear);

        _ = titleLabel.FadeTo(1, 100, Easing.SinIn);

    }

    async void HidePageContents()
    {
        _ = theLine.FadeTo(0, 250, Easing.Linear);
        await titleLabel.FadeTo(0, 100, Easing.SinOut);

    }

    

    //async void ListView_ItemTapped(System.Object sender, ItemTappedEventArgs e)
    //{
    //    if((LibraryItems)((ListView)sender).SelectedItem != previouslySeletedItem)
    //        previouslySeletedItem = (LibraryItems)((ListView)sender).SelectedItem;

    //    TheListView.SelectedItem = null;

    //    string route = previouslySeletedItem.Title + "Page";
    //    await Shell.Current.GoToAsync(route);
        


         
    //}

    
    //void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    //{
    //    var theSender = (LibraryItems)sender;
    //}
    #endregion
}