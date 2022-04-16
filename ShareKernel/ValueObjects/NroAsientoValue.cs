using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record NroAsientoValue : ValueObject
    {
        public int Fila { get; set; }
        public char Columna { get; set; }
        public NroAsientoValue(int fila, char columna)
        {
            if (Fila <= 0)
            {
                throw new BussinessRuleValidationException("La fila no puede ser negativa o cero");
            }

            Fila = fila;
            Columna = columna;
        }
        public static implicit operator string(NroAsientoValue value)
        {
            return value.Fila.ToString()+value.Columna;
        }

        
    }
}
