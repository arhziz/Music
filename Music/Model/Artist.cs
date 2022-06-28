namespace Music.Model;

public record Artist
{
    public string Title { get; set; }
    public string ProfilePicture { get; set; }
    public string Wallpicture { get; set; }
    public ArtistBio Bio { get; set; }

}
