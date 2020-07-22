using Blog.Interface;
using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class TagsService:ITagsService
    {
        private readonly MyDbContext _context;
        public TagsService(MyDbContext context) { _context=context; }

        public List<TagVM> Get()
        {
            List<TagVM> list = _context.Tags
               .Select(x => new TagVM()
               {
                   tagList = x.AllowedBars
               }).ToList();

            return list;
        }
    }
}
