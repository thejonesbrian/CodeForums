using CodeForums.Data;
using CodeForums.Models.ForumModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CodeForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        public ForumController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListModel
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
                });
            //
            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }
        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = _postService.GetFilteredPosts(id)

            var postListings = 
        }
    }
}