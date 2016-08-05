using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        /// <summary>
        /// 艺术家ID
        /// </summary>
        public virtual int ArtistId { get; set; }

        /// <summary>
        /// 艺术家名字
        /// </summary>
        public virtual string Name { get; set; }
    }
}