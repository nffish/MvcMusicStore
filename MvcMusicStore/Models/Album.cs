namespace MvcMusicStore.Models
{
    public class Album
	{
        /// <summary>
        /// 专辑ID
        /// </summary>
        public  virtual int AlbumId { get; set; }

        public virtual int GenreId { get; set; }

        public virtual int ArtistId { get; set; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string AlbumArtUrl { get; set; }

        /// <summary>
        /// 类型,流派
        /// </summary>
        public virtual Genre Genre { get; set; }

        /// <summary>
        /// 艺术家,歌手
        /// </summary>
        public virtual Artist Artist { get; set; }
    }
}
