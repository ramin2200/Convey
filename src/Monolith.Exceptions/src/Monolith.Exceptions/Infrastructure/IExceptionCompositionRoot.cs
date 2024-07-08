using Monolith.Exceptions;
using System;

namespace Monolith.Exceptions.Infrastructure;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}