namespace Music.Helpers.Controls;

public partial class NavButton : ContentView
{
    
    public NavButton()
	{
		InitializeComponent();
	}



    #region NavIcon
    public static readonly BindableProperty NavIconProperty = BindableProperty.Create(nameof(NavIcon), typeof(string), typeof(NavButton), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as NavButton;
        if (newV != null && !(newV is string)) return;
        var oldNavIcon = (string)old;
        var newNavIcon = (string)newV;
        me?.NavIconChanged(oldNavIcon, newNavIcon);
    });

    private void NavIconChanged(string oldNavIcon, string newNavIcon)
    {
        IconLabel.Text = newNavIcon;
    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public string NavIcon
    {
        get => (string)GetValue(NavIconProperty);
        set => SetValue(NavIconProperty, value);
    }
    #endregion

    #region NavText
    public static readonly BindableProperty NavTextProperty = BindableProperty.Create(nameof(NavText), typeof(string), typeof(NavButton), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as NavButton;
        if (newV != null && !(newV is string)) return;
        var oldNavText = (string)old;
        var newNavText = (string)newV;
        me?.NavTextChanged(oldNavText, newNavText);
    });

    private void NavTextChanged(string oldNavText, string newNavText)
    {
        NavTextLabel.Text = newNavText;
    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public string NavText
    {
        get => (string)GetValue(NavTextProperty);
        set => SetValue(NavTextProperty, value);
    }
    #endregion

    #region IsActive
    public static readonly BindableProperty IsActiveProperty = BindableProperty.Create(nameof(IsActive), typeof(bool), typeof(NavButton), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as NavButton;
        if (newV != null && !(newV is bool)) return;
        var oldIsActive = (bool)old;
        var newIsActive = (bool)newV;
        me?.IsActiveChanged(oldIsActive, newIsActive);
    });

    private void IsActiveChanged(bool oldIsActive, bool newIsActive)
    {
        if (newIsActive)
        {
            IconLabel.TextColor = Color.FromHex("#f92d48");
            NavTextLabel.TextColor = Color.FromHex("#f92d48");
        }

    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public bool IsActive
    {
        get => (bool)GetValue(IsActiveProperty);
        set => SetValue(IsActiveProperty, value);
    }
    #endregion




    #region IconSize
    public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(nameof(IconSize), typeof(int), typeof(NavButton), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as NavButton;
        if (newV != null && !(newV is int)) return;
        var oldIconSize = (int)old;
        var newIconSize = (int)newV;
        me?.IconSizeChanged(oldIconSize, newIconSize);
    });

    private void IconSizeChanged(int oldIconSize, int newIconSize)
    {
        IconLabel.FontSize = (double)newIconSize;
    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public int IconSize
    {
        get => (int)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }
    #endregion



}