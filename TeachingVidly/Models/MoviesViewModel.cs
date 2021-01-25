using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeachingVidly.Models
{
    public class MoviesViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}