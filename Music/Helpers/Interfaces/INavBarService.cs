namespace Music.Helpers.Interfaces
{
    public interface INavBarService
    {
#if ANDROID
        void SetNabBarColor(Color color);
        void SetStatusBarColor(Color color);
        void SetNavSeparationColor(Color color);
#endif


    }
}
