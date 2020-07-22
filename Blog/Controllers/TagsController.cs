using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blog.ViewModels;
using Blog.Interface;
using Blog.Models;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly ITagsService _service;

        public TagsController(MyDbContext context, ITagsService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/Tags
        [HttpGet]
        public List<TagVM> Get()
        {
            return _service.Get();
        }

    }
}
