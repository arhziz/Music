using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Music;
using Music.Helpers.Controls;
using Music.Helpers.Interfaces;
using Android.Views;
using Platform = Microsoft.Maui.ApplicationModel.Platform;
using static Music.MainActivity;


namespace Music;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#1c1c1e"));
        Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#1c1c1e"));
#if ANDROID28_0_OR_GREATER
        Window.NavigationBarDividerColor = Android.Graphics.Color.ParseColor("#1c1c1e");
#endif

    }
    
    public class NavBarService : INavBarService
    {
        

        public void SetNabBarColor(Color color)
        {
            Platform.CurrentActivity?.Window.SetNavigationBarColor(color.ToAndroid());
        }

        public void SetStatusBarColor(Color color)
        {
            Platform.CurrentActivity?.Window.SetStatusBarColor(color.ToAndroid());
            //Platform.Window.SetStatusBarColor(Android.Graphics.Color.ParseColor(color));
        }

        public void SetNavSeparationColor(Color color)
        {
#if ANDROID28_0_OR_GREATER
            //Platform.CurrentActivity?.Window.NavigationBarDividerColor=color.ToAndroid();
#endif
        }
    }
}




