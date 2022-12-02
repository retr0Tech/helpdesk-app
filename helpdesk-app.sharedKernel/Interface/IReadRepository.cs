
namespace helpdesk_app.sharedKernel.Interface
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}