using Aula_2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adicionar os Metodos dos Cenarios Aqui
            Scenario_4_LINQ();

            Console.ReadKey();
        }

        #region Scenario_1
        private static void Scenario_1_LINQ()
        {

            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

            // words.Length    PEgando a quantidade de elementos do Array

            //var shortWords = from w in words
            //                 where w.Length <= 5
            //                 select w;

            // Lambda
            var shortWords = words.Where(w => Condition(w));

            /// shortWords.Count(); PEgando a quantidade de elementos de IEnumerable<>

            foreach (var item in shortWords)
            {
                Console.WriteLine(item);
            }

            // Example: Livro 'LINQ in Action' Cp 1
        }

        private static bool Condition(string w)
        {
            return w.Length <= 5;
        }

        private static void Scenario_1_OldSchool()
        {
            string[] words = new string[] { "hello", "wonderful", "linq", "beautiful", "world" };

            foreach (string word in words)
            {
                if (word.Length <= 5)
                    Console.WriteLine(word);
            }

            // Example: Livro 'LINQ in Action' Cp 1
        }

        #endregion

        #region Scenario_2
        
        private static void Scenario_2_LINQ()
        {
            var results = from book in SampleData.Books
                          group book.Title by book.Publisher.Name into publisherBooks
                          orderby publisherBooks.Key 
                          select publisherBooks;

            foreach (var titleGroup in results)
            {
                Console.WriteLine($"Author: {titleGroup.Key}");
                foreach (var publisherName in titleGroup)
                {
                    Console.WriteLine($"{publisherName}");
                }
            }

            // Example: Livro 'LINQ in Action' Cp 5
        }

        private static void Scenario_2_without_LINQ()
        {
            // O (lg (n))
            var results = new SortedDictionary<String, IList<String>>();

            foreach (var book in SampleData.Books)
            {
                IList<String> publisherBooks;
                // var values = results["Key"];
                bool condition = results.TryGetValue(book.Publisher.Name, out publisherBooks);
                if (!condition)
                {
                    publisherBooks = new List<String>();
                    results[book.Publisher.Name] = publisherBooks;
                }
                publisherBooks.Add(book.Title);
            }

            foreach (var AuthorGroup in results)
            {
                Console.WriteLine($"Author: {AuthorGroup.Key}");
                foreach (var publisherName in AuthorGroup.Value)
                {
                    Console.WriteLine($"{publisherName}");
                }
            }

            // Example: Livro 'LINQ in Action' Cp 5
        }

        #endregion

        #region Scenario_3

        public static void Scenario_3_LINQ()
        {
            var books = new[] {
              new {Title="Ajax in Action", Publisher="Manning", Year=2005 },
              new {Title="Windows Forms in Action", Publisher="Manning", Year=2006 },
              new {Title="RSS and Atom in Action", Publisher="Manning", Year=2006 }
            };

            // Build the XML fragment based on the collection

            XElement xml = new XElement("books",
                          from book in books
                          where book.Year == 2006
                          select new XElement("book",
                            new XElement("title", book.Title),
                            new XElement("publisher", book.Publisher)
                          )
                        );

            Console.WriteLine(xml);
            // Example: Livro 'LINQ in Action' Cp 1
        }
        
        public static void Scenario_3_without_LINQ()
        {
            Book[] books = new Book[] {
            new Book("Ajax in Action", "Manning", 2005),
            new Book("Windows Forms in Action", "Manning", 2006),
            new Book("RSS and Atom in Action", "Manning", 2006)
          };

            // Build the XML fragment based on the collection            
            XDocument doc = new XDocument();
            XElement root = new XElement("books");
            foreach (Book book in books)
            {
                if (book.Year == 2006)
                {
                    XElement element = new XElement("book");
                    element.Add(new XAttribute("title", book.Title));

                    XElement publisher = new XElement("publisher");
                    publisher.Add(book.Publisher);
                    element.Add(publisher);

                    root.Add(element);
                }
            }
            doc.Add(root);

            // Display the result XML
            doc.Save(Console.Out);
        }


        class Book
        {
            public string Title;
            public string Publisher;
            public int Year;

            public Book(string title, string publisher, int year)
            {
                Title = title;
                Publisher = publisher;
                Year = year;
            }
        }
        #endregion

        #region Scenario_4
        public static void Scenario_4_LINQ()
        {
            var prescricoes = SampleData.Prescriptions1;
            
            foreach (var item in prescricoes)
            {
                // Console.WriteLine($"Data: {item.DateTime} | Descrição: {item.Description})"
                Console.WriteLine(item);
            }


            var prescricoesB = prescricoes
                .GroupBy(p =>  p.DateTime.ToShortDateString(),
                         p =>  new DescriptionOfPrescriptionB() { Description = p.Description, Time = p.DateTime.ToShortTimeString() }                        
                        )
                .Select(p => 
                {
                    return new PrescriptionB()
                    {
                        DateTime = p.Key,
                        Descriptions = p.AsEnumerable().OrderBy(d => d.Time)
                    };
                });


            foreach (var pres in prescricoesB)
            {
                Console.WriteLine(pres.DateTime);
                foreach (var data in pres.Descriptions)
                {
                    Console.WriteLine(data);
                }
            }

            /***
             * 
             * Data | Desc                    
                        - Data 01/07/2019
                             - 10:20 | Remedio
                             - 12:30 | Remedio
                    
                        - Data 01/07/2019
                             - 10:20 | Remedio
                             - 12:30 | Remedio

             * 
             * */

        }
        #endregion

    }




}
