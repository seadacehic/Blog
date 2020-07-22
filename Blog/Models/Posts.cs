using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Posts
    {
        [Key]
        public string BlogSlug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAtDate { get; set; }
        public DateTime UpdatedAtDate { get; set; }

        public int TagsId { get; set; }
        [ForeignKey(nameof(TagsId))]
        public virtual Tags Tags { get; set; }


        //public static string GenerateSlug(this string phrase)
        //{
        //    string str = phrase.RemoveAccent().ToLower();

        //    str = Regex.Replace(str, @"[^a-z0-9\s-]", ""); // invalid chars          
        //    str = Regex.Replace(str, @"\s+", " ").Trim(); // convert multiple spaces into one space  
        //    str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim(); // cut and trim it  
        //    str = Regex.Replace(str, @"\s", "-"); // hyphens  

        //    return str;
        //}

        //public static string RemoveAccent(this string txt)
        //{
        //    byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
        //    return System.Text.Encoding.ASCII.GetString(bytes);
        //}

        //public static string ToUrlSlug(string value)
        //{

        //    //First to lower case
        //    value = value.ToLowerInvariant();

        //    //Remove all accents
        //    var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);
        //    value = Encoding.ASCII.GetString(bytes);

        //    //Replace spaces
        //    value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

        //    //Remove invalid chars
        //    value = Regex.Replace(value, @"[^a-z0-9\s-_]", "", RegexOptions.Compiled);

        //    //Trim dashes from end
        //    value = value.Trim('-', '_');

        //    //Replace double occurences of - or _
        //    value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

        //    return value;
        //}

        /// <summary>  
        /// Contains all custom written string related Extension Methods.  
        /// </summary>  
        //public static class StringExtensions
        //{
        //    /// <summary>  
        //    /// Removes all accents from the input string.  
        //    /// </summary>  
        //    /// <param name="text">The input string.</param>  
        //    /// <returns></returns>  
        //    public static string RemoveAccents(this string text)
        //    {
        //        if (string.IsNullOrWhiteSpace(text))
        //            return text;

        //        text = text.Normalize(NormalizationForm.FormD);
        //        char[] chars = text
        //            .Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
        //            != UnicodeCategory.NonSpacingMark).ToArray();

        //        return new string(chars).Normalize(NormalizationForm.FormC);
        //    }

        //    /// <summary>  
        //    /// Turn a string into a slug by removing all accents,   
        //    /// special characters, additional spaces, substituting   
        //    /// spaces with hyphens & making it lower-case.  
        //    /// </summary>  
        //    /// <param name="phrase">The string to turn into a slug.</param>  
        //    /// <returns></returns>  
        //    public static string Slugify(this string phrase)
        //    {
        //        // Remove all accents and make the string lower case.  
        //        string output = phrase.RemoveAccents().ToLower();

        //        // Remove all special characters from the string.  
        //        output = Regex.Replace(output, @"[^A-Za-z0-9\s-]", "");

        //        // Remove all additional spaces in favour of just one.  
        //        output = Regex.Replace(output, @"\s+", " ").Trim();

        //        // Replace all spaces with the hyphen.  
        //        output = Regex.Replace(output, @"\s", "-");

        //        // Return the slug.  
        //        return output;
        //    }
        //}




    }
}
