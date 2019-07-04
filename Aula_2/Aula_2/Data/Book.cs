using System;
using System.Collections.Generic;

namespace Aula_2.Data
{
    public class Book
    {
        public IEnumerable<Author> Authors { get; set;}

        public string Isbn { get; set; }

        public string Notes { get; set; }

        public int PageCount { get; set; }

        public decimal Price { get; set; }

        public DateTime PublicationDate { get; set;}

        public Publisher Publisher { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        public Subject Subject { get; set;}

        public string Summary { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }


}
