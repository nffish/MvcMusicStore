using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        /// <summary>
        /// 流派ID
        /// </summary>
        public virtual int GenreId { get; set; }

        /// <summary>
        /// 流派名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 流派介绍
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// 专辑列表
        /// </summary>
        public virtual List<Album> Albums { get; set; }
    }
}