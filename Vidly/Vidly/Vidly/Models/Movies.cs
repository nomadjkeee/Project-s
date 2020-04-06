using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public short Year { get; set; }
        public string Type { get; set; }
    }
}