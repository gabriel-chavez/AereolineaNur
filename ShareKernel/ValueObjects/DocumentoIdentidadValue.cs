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
        public string Numero { get; }
        public TipoDocumentoEnum TipoDocumento { get; }

        public DocumentoIdentidadValue(string numero,TipoDocumentoEnum tipoDocumento)
        {
            CheckRule(new StringNotNullOrEmptyRule(numero));
            if (Numero.Length < 4)
            {
                throw new BussinessRuleValidationException("El número introducido debe ser mayor a 3 digitos");
            }
            Numero = numero;
            TipoDocumento= tipoDocumento;
        }

        public static implicit operator string(DocumentoIdentidadValue value)
        {
            return value.Numero;
        }

        public static implicit operator DocumentoIdentidadValue(string numero)
        {
            return new DocumentoIdentidadValue(numero);
        }
    }
}
