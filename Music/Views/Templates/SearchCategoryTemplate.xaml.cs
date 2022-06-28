

namespace Music.Views.Templates;

public partial class SearchCategoryTemplate : ContentView
{
	public SearchCategoryTemplate()
	{
		InitializeComponent();
	}



    #region Title
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(SearchCategoryTemplate), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as SearchCategoryTemplate;
        if (newV != null && !(newV is string)) return;
        var oldTitle = (string)old;
        var newTitle = (string)newV;
        me?.TitleChanged(oldTitle, newTitle);
    });

    private void TitleChanged(string oldTitle, string newTitle)
    {
        titleLabel.Text = newTitle;
    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    #endregion



    #region ImageSrc
    public static readonly BindableProperty ImageSrcProperty = BindableProperty.Create(nameof(ImageSrc), typeof(ImageSource), typeof(SearchCategoryTemplate), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as SearchCategoryTemplate;
        if (newV != null && !(newV is ImageSource)) return;
        var oldImageSrc = (ImageSource)old;
        var newImageSrc = (ImageSource)newV;
        me?.ImageSrcChanged(oldImageSrc, newImageSrc);
    });

    private void ImageSrcChanged(ImageSource oldImageSrc, ImageSource newImageSrc)
    {
        templateImage.Source = newImageSrc;
    }

    /// <summary>
    /// A bindable property
    /// </summary>
    public ImageSource ImageSrc
    {
        get => (ImageSource)GetValue(ImageSrcProperty);
        set => SetValue(ImageSrcProperty, value);
    }
    #endregion


}