using Blog.Helper;
using Blog.Interface;
using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class PostsService : IPostsService
    {
        private readonly MyDbContext _context;
        public PostsService(MyDbContext context) { _context = context; }

        public List<PostVM> Get()
        {
            List<PostVM> list = _context.Posts.Select(x => new PostVM
            {
                BlogSlug = x.BlogSlug,
                Title = x.Title,
                Description = x.Description,
                Body = x.Body,
                CreatedAtDate = x.CreatedAtDate,
                UpdatedAtDate = x.UpdatedAtDate,
                tagList = x.Tags.AllowedBars
            }).OrderByDescending(o => o.CreatedAtDate).ToList(); //it filters most recent posts

            return list;
        }

        public PostVM Get(string slug)
        {
            PostVM obj = _context.Posts.Where(w => w.BlogSlug == slug)
                .Select(x => new PostVM
                {
                    BlogSlug = x.BlogSlug,
                    Title = x.Title,
                    Description = x.Description,
                    Body = x.Body,
                    CreatedAtDate = x.CreatedAtDate,
                    UpdatedAtDate = x.UpdatedAtDate,
                    tagList = x.Tags.AllowedBars
                }).FirstOrDefault();
            return obj;
        }

        public bool Post(Posts posts)
        {
            Posts obj = new Posts();
            obj.BlogSlug = GetFriendlyTitle(posts.BlogSlug);
            obj.Title = posts.Title;
            obj.Description = posts.Description;
            obj.Body = posts.Body;
            obj.CreatedAtDate = DateTime.Now;
            obj.UpdatedAtDate = DateTime.Now;
            obj.TagsId = posts.TagsId;
            _context.Posts.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public static string GetFriendlyTitle(string title)
        {
            int maxlength = 80;
            bool remapToAscii = false;

            if (title == null)
            {
                return string.Empty;
            }

            int length = title.Length;
            bool prevdash = false;
            StringBuilder stringBuilder = new StringBuilder(length);
            char c;

            for (int i = 0; i < length; ++i)
            {
                c = title[i];
                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    stringBuilder.Append(c);
                    prevdash = false;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    // tricky way to convert to lower-case
                    stringBuilder.Append((char)(c | 32));
                    prevdash = false;
                }
                else if ((c == ' ') || (c == ',') || (c == '.') || (c == '/') ||
                  (c == '\\') || (c == '-') || (c == '_') || (c == '='))
                {
                    if (!prevdash && (stringBuilder.Length > 0))
                    {
                        stringBuilder.Append('-');
                        prevdash = true;
                    }
                }
                else if (c >= 128)
                {
                    int previousLength = stringBuilder.Length;

                    if (!remapToAscii)
                    {
                        stringBuilder.Append(RemapInternationalCharToAscii(c));
                    }
                    else
                    {
                        stringBuilder.Append(c);
                    }

                    if (previousLength != stringBuilder.Length)
                    {
                        prevdash = false;
                    }
                }

                if (i == maxlength)
                {
                    break;
                }
            }

            if (prevdash)
            {
                return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
            }
            else
            {
                return stringBuilder.ToString();
            }
        }

        private static string RemapInternationalCharToAscii(char character)
        {
            string s = character.ToString().ToLowerInvariant();
            if ("àåáâäãåąā".Contains(s))
            {
                return "a";
            }
            else if ("èéêëę".Contains(s))
            {
                return "e";
            }
            else if ("ìíîïı".Contains(s))
            {
                return "i";
            }
            else if ("òóôõöøő".Contains(s))
            {
                return "o";
            }
            else if ("ùúûüŭů".Contains(s))
            {
                return "u";
            }
            else if ("çćčĉ".Contains(s))
            {
                return "c";
            }
            else if ("żźž".Contains(s))
            {
                return "z";
            }
            else if ("śşšŝ".Contains(s))
            {
                return "s";
            }
            else if ("ñń".Contains(s))
            {
                return "n";
            }
            else if ("ýÿ".Contains(s))
            {
                return "y";
            }
            else if ("ğĝ".Contains(s))
            {
                return "g";
            }
            else if (character == 'ř')
            {
                return "r";
            }
            else if (character == 'ł')
            {
                return "l";
            }
            else if ("đð".Contains(s))
            {
                return "d";
            }
            else if (character == 'ß')
            {
                return "ss";
            }
            else if (character == 'Þ')
            {
                return "th";
            }
            else if (character == 'ĥ')
            {
                return "h";
            }
            else if (character == 'ĵ')
            {
                return "j";
            }
            else
            {
                return string.Empty;
            }
        }

        public bool Put(string slug, Posts posts)
        {
            if (posts.BlogSlug != slug)
            {
                return false;
            }
            Posts obj = new Posts();
            obj.BlogSlug = posts.BlogSlug;
            obj.Title = posts.Title;
            obj.Description = posts.Description;
            obj.Body = posts.Body;
            obj.CreatedAtDate = obj.CreatedAtDate;
            obj.UpdatedAtDate = DateTime.Now;
            obj.TagsId = posts.TagsId;
            _context.Posts.Update(posts);

            if (_context.SaveChanges() == 1)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string slug)
        {
            var posts = _context.Posts.Find(slug);
            if (posts == null)
            {
                return false;
            }

            _context.Posts.Remove(posts);
            _context.SaveChanges();
            return true;
        }

    }
}
