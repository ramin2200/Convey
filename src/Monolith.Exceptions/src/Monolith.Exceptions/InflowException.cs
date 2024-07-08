using System;

namespace Monolith.Exceptions;

public abstract class InflowException : Exception
{
    protected InflowException(string message) : base(message)
    {
    }
}