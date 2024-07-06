using System.Collections.Generic;

namespace Convey.Module.Monolithic;

internal record ModuleInfo(string Name, IEnumerable<string> Policies);