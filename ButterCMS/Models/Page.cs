﻿using System.Collections.Generic;

namespace ButterCMS.Models
{
    public class Page<T>
    {
        public string Slug { get; set; }
        public string PageType { get; set; }
        public T Fields { get; set; }
    }
}
