using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostVM
    {
        public string BlogSlug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAtDate { get; set; }
        public DateTime UpdatedAtDate { get; set; }
        public List<string> tagList { get; set; }
        //public int tagId { get; set; }
    }
}
