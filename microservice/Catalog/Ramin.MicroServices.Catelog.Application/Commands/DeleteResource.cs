using Convey.CQRS.Commands;
using System;

namespace Ramin.MicroServices.Catelog.Application.Commands
{
    [Contract]
    public class DeleteResource : ICommand
    {
        public Guid ResourceId { get; }

        public DeleteResource(Guid resourceId)
            => ResourceId = resourceId;
    }
}