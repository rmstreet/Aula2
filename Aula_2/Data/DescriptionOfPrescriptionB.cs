﻿namespace Aula_2.Data
{
    public class DescriptionOfPrescriptionB
    {
        public string Time { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {

            return $"Hora: {Time} | Remedio: {Description} ";
        }

    }
}
