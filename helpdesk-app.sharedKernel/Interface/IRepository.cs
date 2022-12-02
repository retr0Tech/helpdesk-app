
namespace helpdesk_app.sharedKernel.Interface;

  // from Ardalis.Specification
  public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
  {
  }
