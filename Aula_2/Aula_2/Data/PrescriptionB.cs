using System;
using System.Collections.Generic;

namespace Aula_2.Data
{
    public class PrescriptionB
    {
        public DateTime DateTime { get; set; }
        public IEnumerable<DescriptionOfPrescriptionB> Descriptions { get; set; }
    }
}
