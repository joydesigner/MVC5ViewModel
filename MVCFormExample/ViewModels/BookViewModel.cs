using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormExample.ViewModels
{
    public class BookViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public int Rating { get; set; }

    }
}