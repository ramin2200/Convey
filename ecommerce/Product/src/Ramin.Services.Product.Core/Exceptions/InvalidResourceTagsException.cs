using Convey.Domain.Exceptions;

namespace Ramin.Services.Products.Core.Exceptions
{
    public class InvalidResourceTagsException : DomainException
    {
        public override string Code { get; } = "invalid_resource_tags";

        public InvalidResourceTagsException() : base("Resource tags are invalid.")
        {
        }
    }
}