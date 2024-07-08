using System.Net;

namespace Monolith.Exceptions;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);