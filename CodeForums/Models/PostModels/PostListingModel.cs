using CodeForums.Models.ForumModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeForums.Models.PostModels
{
    public class PostListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorRating { get; set; }
        public string AuthorId { get; set; }
        public string DatePosted { get; set; }

        public ForumListModel Forum { get; set; }

        public int RepliesCount { get; set; }
    }
}
