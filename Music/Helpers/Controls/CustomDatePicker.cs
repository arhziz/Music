namespace Music.Helpers.Controls;

public class CustomDatePicker : DatePicker
{


    public static readonly BindableProperty CheckOnLoadProperty =
     BindableProperty.Create(nameof(CheckOnLoad), typeof(bool), typeof(DatePicker), false, BindingMode.TwoWay);

    public bool CheckOnLoad
    {
        get { return (bool)base.GetValue(CheckOnLoadProperty); }
        private set { base.SetValue(CheckOnLoadProperty, value); }
    }

    public static readonly BindableProperty IsBorderErrorVisibleProperty =
        BindableProperty.Create(nameof(IsBorderErrorVisible), typeof(bool), typeof(DatePicker), false, BindingMode.TwoWay);

    public bool IsBorderErrorVisible
    {
        get { return (bool)GetValue(IsBorderErrorVisibleProperty); }
        set
        {
            SetValue(IsBorderErrorVisibleProperty, value);
        }
    }

    public static readonly BindableProperty BorderErrorColorProperty =
        BindableProperty.Create(nameof(BorderErrorColor), typeof(Color), typeof(DatePicker), Colors.Transparent, BindingMode.TwoWay);

    public Color BorderErrorColor
    {
        get { return (Color)GetValue(BorderErrorColorProperty); }
        set
        {
            SetValue(BorderErrorColorProperty, value);
        }
    }

    public static readonly BindableProperty ErrorTextProperty =
        BindableProperty.Create(nameof(ErrorText), typeof(string), typeof(DatePicker), string.Empty);


    /// <summary>
    /// THe name of the field that should display in the error message
    /// </summary>
    public string ErrorText
    {
        get { return (string)GetValue(ErrorTextProperty); }
        set
        {
            SetValue(ErrorTextProperty, value);
        }
    }

    public static readonly BindableProperty IsRequiredProperty =
        BindableProperty.Create(nameof(IsRequired), typeof(bool), typeof(DatePicker), false);

    public bool IsRequired
    {
        get { return (bool)GetValue(IsRequiredProperty); }
        set
        {
            SetValue(IsRequiredProperty, value);
        }
    }
}