using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public Movie() { }

        public string Title { get; set; }
        public string Category { get; set; }
    }
}
