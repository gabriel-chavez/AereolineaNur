using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record NroAsientoColumnaValue:ValueObject
    {
        public char Columna { get;  }
        private char[] RangoColumnas;
        public NroAsientoColumnaValue( char columna)
        {
            RangoColumnas =new char[] { 'A', 'B', 'C', 'D' };
            if (RangoColumnas.Where(x => x == columna).ToList().Count()==0)
            {
                throw new BussinessRuleValidationException("La columna debe estar en el rango de A a D ");
            }

            Columna = columna;

        }        
        public static implicit operator char(NroAsientoColumnaValue value)
        {
            return value.Columna;
        }

        public static implicit operator NroAsientoColumnaValue(char columna)
        {
            return new NroAsientoColumnaValue(columna);
        }
    }
}
