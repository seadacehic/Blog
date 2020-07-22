using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interface
{
    public interface ITagsService
    {
        List<TagVM> Get();
    }
}
