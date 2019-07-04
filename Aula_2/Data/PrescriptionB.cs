using System;
using System.Collections.Generic;

namespace Aula_2.Data
{
    public class PrescriptionB
    {
        public string DateTime { get; set; }
        public IEnumerable<DescriptionOfPrescriptionB> Descriptions { get; set; }
        
    }
}
