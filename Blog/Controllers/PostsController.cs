using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;
using Blog.ViewModels;
using Blog.Interface;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IPostsService _service;

        public PostsController(MyDbContext context,IPostsService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/Posts
        [HttpGet]
        public List<PostVM> Get()
        {
            return _service.Get();
        }

        // GET: api/Posts/slug
        [HttpGet]
        //[Route("Get/{slug}")]
        [Route("{slug}")]
        public PostVM Get(string slug)
        {
            return _service.Get(slug);
        }

        // POST: api/Posts
        [HttpPost]
        public bool Post(Posts posts)
        {
            return _service.Post(posts);
        }

        //PUT: api/Posts/5
        [HttpPut("{slug}")]
        public bool Put(string slug, Posts posts)
        {
            return _service.Put(slug, posts);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public bool Delete(string slug)
        {
            return _service.Delete(slug);
        }



    }
}
