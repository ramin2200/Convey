using Convey.WebApi.Exceptions;
using System;
using System.Net;

namespace Conveyor.Services.MY1
{
    public class ExceptionToResponseMapper : IExceptionToResponseMapper
    {
        public ExceptionResponse Map(Exception exception)
            => new(new { code = "error", message = exception.Message }, HttpStatusCode.BadRequest);
    }
}