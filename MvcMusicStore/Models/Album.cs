namespace MvcMusicStore.Models
{
    public class Album
	{
        /// <summary>
        /// ר��ID
        /// </summary>
        public  virtual int AlbumId { get; set; }

        public virtual int GenreId { get; set; }

        public virtual int ArtistId { get; set; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string AlbumArtUrl { get; set; }

        /// <summary>
        /// ����,����
        /// </summary>
        public virtual Genre Genre { get; set; }

        /// <summary>
        /// ������,����
        /// </summary>
        public virtual Artist Artist { get; set; }
    }
}
