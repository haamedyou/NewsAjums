using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Ajums.CoreLayer.DTOs.Posts
{
    public class PostSlidShowDto
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        public string ImageName { get; set; }

        public bool IsSpecial { get; set; }
    }
}
