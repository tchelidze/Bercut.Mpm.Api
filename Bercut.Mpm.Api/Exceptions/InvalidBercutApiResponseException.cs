using System;
using System.Net;

namespace Bercut.Mpm.Api.Exceptions
{
    public class InvalidBercutApiResponseException : Exception
    {
        public InvalidBercutApiResponseException(
            HttpStatusCode invalidHttpStatusCode,
            string errorMessage)
        {
            InvalidHttpStatusCode = invalidHttpStatusCode;
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public HttpStatusCode InvalidHttpStatusCode { get; }
    }
}