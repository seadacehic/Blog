using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Tags
    {
        [Key]
        public int TagsId { get; set; }

        [NotMapped]
        public List<string> AllowedBars { get; set; }
        public string AllowedBarsList
        {
            get { return string.Join(",", AllowedBars); }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    AllowedBars.Clear();
                }
                else
                {
                    AllowedBars = value.Split(',').ToList();
                }
            }
        }
    }
}
