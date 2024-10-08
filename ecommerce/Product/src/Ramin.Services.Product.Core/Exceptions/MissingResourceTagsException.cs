using Convey.Domain.Exceptions;

namespace Ramin.Services.Products.Core.Exceptions
{
    public class MissingResourceTagsException : DomainException
    {
        public override string Code { get; } = "missing_resource_tags";

        public MissingResourceTagsException() : base("Resource tags are missing.")
        {
        }
    }
}