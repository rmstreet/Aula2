using System;
using System.Collections.Generic;

namespace Aula_2.Data
{
    public static class SampleData
    {
        public static Publisher[] Publishers = new Publisher[3]
        {
            new Publisher { Name = "FunBooks" },
            new Publisher { Name = "Joe Publishing" },
            new Publisher { Name = "I Publisher" }
        };

        public static Author[] Authors = new Author[4]
        {
            new Author { FirstName = "Johnny", LastName = "Good" },
            new Author { FirstName = "Graziella", LastName = "Simplegame" },
            new Author { FirstName = "Octavio", LastName = "Prince" },
            new Author { FirstName = "Jeremy", LastName = "Legrand" }
        };

        public static Subject[] Subjects = new Subject[3]
        {
            new Subject { Name = "Software development" },
            new Subject { Name = "Novel" },
            new Subject { Name = "Science fiction" }
        };

        public static Book[] Books = new Book[5]
        {
            new Book {
                Title = "Funny Stories",
                Publisher = Publishers[0],
                Authors = new Author[2] { Authors[0], Authors[1] },
                PageCount = 101,
                Price = 25.55m,
                PublicationDate = new DateTime(2004, 11, 10),
                Isbn = "0-000-77777-2",
                Subject = Subjects[0]
            },
            new Book
            {
                Title = "LINQ rules",
                Publisher = Publishers[1],
                Authors = new Author[1] { Authors[2] },
                PageCount = 300,
                Price = 12m,
                PublicationDate = new DateTime(2007, 9, 2),
                Isbn = "0-111-77777-2",
                Subject = Subjects[0]
            },
            new Book
            {
                Title = "C# on Rails",
                Publisher = Publishers[1],
                Authors = new Author[1] { Authors[2] },
                PageCount = 256,
                Price = 35.5m,
                PublicationDate = new DateTime(2007, 4, 1),
                Isbn = "0-222-77777-2",
                Subject = Subjects[0]
            },
            new Book
            {
                Title = "All your base are belong to us",
                Publisher = Publishers[1],
                Authors = new Author[1] { Authors[3] },
                PageCount = 1205,
                Price = 35.5m,
                PublicationDate = new DateTime(2006, 5, 5),
                Isbn = "0-333-77777-2",
                Subject = Subjects[2]
            },
            new Book
            {   Title = "Bonjour mon Amour",
                Publisher = Publishers[0], 
                Authors = new Author[2] { Authors[1], Authors[0] },
                PageCount = 50,
                Price = 29m,
                PublicationDate = new DateTime(1973, 2, 18),
                Isbn = "2-444-77777-2",
                Subject = Subjects[1]
            }
        };

        public static List<PrescriptionA> Prescriptions1 { get; set; } = new List<PrescriptionA>()
        {
            new PrescriptionA(){ DateTime = DateTime.Now.AddHours(3), Description = "Remedio X" },
            new PrescriptionA(){ DateTime = DateTime.Now, Description = "Remedio Y" },
            new PrescriptionA(){ DateTime = DateTime.Now.AddDays(-1).AddHours(2), Description = "Remedio A" },
            new PrescriptionA(){ DateTime = DateTime.Now.AddDays(-1).AddHours(1), Description = "Remedio X" },
            new PrescriptionA(){ DateTime = DateTime.Now.AddDays(-1).AddHours(7), Description = "Remedio Y" },
            new PrescriptionA(){ DateTime = DateTime.Now.AddDays(-2).AddHours(1), Description = "Remedio C" },
            new PrescriptionA(){ DateTime = DateTime.Now.AddDays(-3).AddHours(-3), Description = "Remedio B" }
        };
    }


}
