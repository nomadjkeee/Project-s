﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class FilmTemplateViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movies Movies { get; set; }

    }
}