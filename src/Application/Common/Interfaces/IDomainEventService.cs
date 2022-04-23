using FYRO.Domain.Common;

namespace FYRO.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
