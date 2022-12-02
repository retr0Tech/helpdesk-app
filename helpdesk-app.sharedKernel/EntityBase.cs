using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace helpdesk_app.sharedKernel
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public string? UpdatedBy { get; set; }

        //private List<DomainEventBase> _domainEvents = new();
        //[NotMapped]
        //public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();
        //protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
        //internal void ClearDomainEvents() => _domainEvents.Clear();
    }
}

