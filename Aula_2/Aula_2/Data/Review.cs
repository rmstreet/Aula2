namespace Aula_2.Data
{
    public class Review
    {
        public Book Book { get; set; }

        public User User { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }
    }


}
