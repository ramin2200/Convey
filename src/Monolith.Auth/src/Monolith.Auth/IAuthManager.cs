using System;
using System.Collections.Generic;

namespace Monolith.Auth;

public interface IAuthManager
{
    JsonWebToken CreateToken(Guid userId, string role = null, string audience = null,
        IDictionary<string, IEnumerable<string>> claims = null);
}