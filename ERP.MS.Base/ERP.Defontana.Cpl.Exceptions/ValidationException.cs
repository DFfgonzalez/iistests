using ERP.Defontana.Cpl.Util;
using System;

namespace ERP.Defontana.Cpl.Exceptions
{
    public class ValidationException : Exception
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public ValidationException() : base("Validacion genérica.") { }

        public ValidationException(int statusCode, string message) { StatusCode = statusCode; StatusMessage = message; }

        public ValidationException(string message, params object[] args) : base(message.F(args)) { }

        public ValidationException(Exception innerException, string message, params object[] args) : base(message.F(args), innerException) { }

    }
}
