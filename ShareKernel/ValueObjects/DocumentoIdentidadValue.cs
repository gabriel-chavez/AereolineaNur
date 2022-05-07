using ShareKernel.Core;
using ShareKernel.Enum;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record DocumentoIdentidadValue : ValueObject
    {
        public int Numero { get; }

        public DocumentoIdentidadValue(int numero)
        {
            var cantidadDigitos=Math.Floor(Math.Log10(numero) + 1);

            if (cantidadDigitos > 0 && cantidadDigitos < 7)
            {
                throw new BussinessRuleValidationException($"El número introducido debe estar en el rango de 1 y 7 dígitos");
            }
            Numero = numero;
         
        }

        public static implicit operator int(DocumentoIdentidadValue value)
        {
            return value.Numero;
        }

        public static implicit operator DocumentoIdentidadValue(int numero)
        {
            return new DocumentoIdentidadValue(numero);
        }
    }
}
