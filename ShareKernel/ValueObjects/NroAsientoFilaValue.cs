using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record NroAsientoFilaValue : ValueObject
    {
        public int Fila { get;}       
        public NroAsientoFilaValue(int fila)
        {
            if (fila <= 0 && fila > 30)
            {
                throw new BussinessRuleValidationException("El número introducido debe estar en el rango de 1 a 30");
            }
            Fila = fila;

        }
      

        public static implicit operator int(NroAsientoFilaValue value)
        {
            return value.Fila;
        }

        public static implicit operator NroAsientoFilaValue(int fila)
        {
            return new NroAsientoFilaValue(fila);
        }
    }
}
