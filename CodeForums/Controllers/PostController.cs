using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeForums.Data;
using CodeForums.Data.Models;
using CodeForums.Models.Post;
using CodeForums.Models.Reply;
using Microsoft.AspNetCore.Mvc;

namespace CodeForums.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            _postService = postService;
        }
        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);

            var replies = BuildPostRplies(post.Replies);

            var model = new PostIndexModel
            {
                 Id = post.Id,
                 Title = post.Title,
                 AuthorId = post.User.Id,
                 AuthorName = post.User.UserName,
                 AuthorImageUrl = post.User.ProfileImageUrl,
                 AuthorRating = post.User.Rating,
                 Created = post.Created,
                 Replies = replies,

            };
            return View();
        }

        private IEnumerable<PostReplyModel> BuildPostRplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply => new PostReplyModel
            {
                Id = reply.Id,
                AuthorName = reply.User.UserName,
                AuthorId = reply.User.Id,
                AuthorImageUrl = reply.User.ProfileImageUrl,
                AuthorRating = reply.User.Rating,
                Created = reply.Created,
                ReplyContent = reply.Content
            });
        }
    }
}