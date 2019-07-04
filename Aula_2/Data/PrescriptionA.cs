using System;
using System.Text;

namespace Aula_2.Data
{
    public class PrescriptionA
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"{DateTime.ToString()} | {Description}";
        }
    }
}
