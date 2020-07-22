using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interface
{
    public interface IPostsService
    {
        List<PostVM> Get();
        PostVM Get(string slug);
        bool Post(Posts posts);
        bool Put(string slug, Posts posts);
        bool Delete(string slug);

    }
}
