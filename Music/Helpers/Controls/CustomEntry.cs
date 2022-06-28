namespace Music.Helpers.Controls;

// All the code in this file is included in all platforms.
public class CustomEntry : Entry
{

    public CustomEntry()
    {
        MaxLength = 350;
    }

    public static readonly BindableProperty AllowEmoticonsProperty =
       BindableProperty.Create(nameof(AllowEmoticons), typeof(bool), typeof(CustomEntry), true, BindingMode.TwoWay);

    public bool AllowEmoticons
    {
        get { return (bool)base.GetValue(AllowEmoticonsProperty); }
        private set { base.SetValue(AllowEmoticonsProperty, value); }
    }

    public static readonly BindableProperty AllowSpecialCharactersProperty =
        BindableProperty.Create(nameof(AllowSpecialCharacters), typeof(bool), typeof(CustomEntry), true, BindingMode.TwoWay);

    public bool AllowSpecialCharacters
    {
        get { return (bool)base.GetValue(AllowSpecialCharactersProperty); }
        private set { base.SetValue(AllowSpecialCharactersProperty, value); }
    }

    public static readonly BindableProperty CheckOnLoadProperty =
        BindableProperty.Create(nameof(CheckOnLoad), typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);

    public bool CheckOnLoad
    {
        get { return (bool)base.GetValue(CheckOnLoadProperty); }
        private set { base.SetValue(CheckOnLoadProperty, value); }
    }


    public static readonly BindableProperty IsBorderErrorVisibleProperty =
        BindableProperty.Create(nameof(IsBorderErrorVisible), typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);

    public bool IsBorderErrorVisible
    {
        get { return (bool)GetValue(IsBorderErrorVisibleProperty); }
        set
        {
            SetValue(IsBorderErrorVisibleProperty, value);
        }
    }

    public static readonly BindableProperty IsOTPProperty =
        BindableProperty.Create(nameof(IsOTP), typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);

    public bool IsOTP
    {
        get { return (bool)GetValue(IsOTPProperty); }
        set
        {
            SetValue(IsOTPProperty, value);
        }
    }

    public static readonly BindableProperty IsWizardControlProperty =
        BindableProperty.Create(nameof(IsWizardControl), typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);

    public bool IsWizardControl
    {
        get { return (bool)GetValue(IsWizardControlProperty); }
        set
        {
            SetValue(IsWizardControlProperty, value);
        }
    }

    public static readonly BindableProperty BorderErrorColorProperty =
        BindableProperty.Create(nameof(BorderErrorColor), typeof(Color), typeof(CustomEntry), Colors.Transparent, BindingMode.TwoWay);

    public Color BorderErrorColor
    {
        get { return (Color)GetValue(BorderErrorColorProperty); }
        set
        {
            SetValue(BorderErrorColorProperty, value);
        }
    }

    public static readonly BindableProperty ErrorTextProperty =
        BindableProperty.Create(nameof(ErrorText), typeof(string), typeof(CustomEntry), string.Empty);


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
        BindableProperty.Create(nameof(IsRequired), typeof(bool), typeof(CustomEntry), false);

    public bool IsRequired
    {
        get { return (bool)GetValue(IsRequiredProperty); }
        set
        {
            SetValue(IsRequiredProperty, value);
        }
    }

    public static readonly BindableProperty ValidationTypeProperty =
        BindableProperty.Create(nameof(ValidationType), typeof(EntryValidatorType), typeof(CustomEntry), EntryValidatorType.Required, BindingMode.TwoWay);

    public EntryValidatorType ValidationType
    {
        get { return (EntryValidatorType)GetValue(ValidationTypeProperty); }
        set
        {
            SetValue(ValidationTypeProperty, value);
        }
    }


  

    public static readonly BindableProperty MinNumberProperty =
        BindableProperty.Create(nameof(MinNumber), typeof(int), typeof(CustomEntry), 0, BindingMode.TwoWay);

    public int MinNumber
    {
        get { return (int)GetValue(MinNumberProperty); }
        set { SetValue(MinNumberProperty, value); }
    }

    public static readonly BindableProperty MaxNumberProperty =
        BindableProperty.Create(nameof(MaxNumber), typeof(int), typeof(CustomEntry), 0, BindingMode.TwoWay);

    public int MaxNumber
    {
        get { return (int)GetValue(MaxNumberProperty); }
        set { SetValue(MaxNumberProperty, value); }
    }
}