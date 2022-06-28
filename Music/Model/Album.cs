namespace Music.Model
{
    public record Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public string AlbumArt { get; set; }
        public List<Song> Songs { get; set; }

        public AlbumDetails Details { get; set; }

    }
}
