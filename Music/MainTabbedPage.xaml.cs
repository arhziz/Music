namespace Music;

public partial class MainTabbedPage : TabbedPage
{
	int count = 0;
	int theCurrentIndex = 0;
	int theLastIndex;
	public MainTabbedPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

    void TabbedPage_CurrentPageChanged(System.Object sender, System.EventArgs e)
    {
#if IOS
		MusicStaticProperties.CurrentTabbedPage = this.Children.IndexOf(this.CurrentPage);
		if(theCurrentIndex != this.Children.IndexOf(this.CurrentPage))
		{
			theLastIndex = theCurrentIndex;
			theCurrentIndex = this.Children.IndexOf(this.CurrentPage);

        }

		//Set the prev icon
		SetPrevIcon();

        this.Children[theCurrentIndex].IconImageSource = new FontImageSource
        {
            Glyph = GetTheIcon(theCurrentIndex),
            FontFamily = "ICO",
            Color = Color.FromHex("#f92d48")
        };

#endif

    }
	private void SetPrevIcon()
	{
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if (currentTheme == AppTheme.Dark)
        {
            this.Children[theLastIndex].IconImageSource = new FontImageSource
            {
                Glyph = GetTheIcon(theLastIndex),
                FontFamily = "ICO",
                Color = Color.FromHex("#EFEFEF")
            };
        }
        else
        {
            this.Children[theLastIndex].IconImageSource = new FontImageSource
            {
                Glyph = GetTheIcon(theLastIndex),
                FontFamily = "ICO",
                Color = Color.FromHex("#1C1C1C")
            };
        }
    }
	private string GetTheIcon(int theIndex)
	{
		switch (theIndex)
		{
			case 0:
				return IcoMoon.PlayCircle;
			case 1:
				return IcoMoon.Grid;
			case 2:
				return IcoMoon.Radio;
			case 3:
				return IcoMoon.Folders;
			case 4:
				return IcoMoon.Search;
			default:
				return IcoMoon.Search;
		}
	}
}

