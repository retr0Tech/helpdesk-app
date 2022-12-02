
namespace helpdesk_app.sharedKernel.Interface
{
  public interface IDomainEventDispatcher
  {
    Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
    Task DispatchSingleEvent(EntityBase entityWithEvent);
  }
}
