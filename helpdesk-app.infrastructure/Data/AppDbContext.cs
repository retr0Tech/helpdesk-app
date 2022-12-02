using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using helpdesk_app.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace helpdesk_app.infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Ticket> ToDoItems => Set<Ticket>();
        public DbSet<User> Projects => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        private void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Deleted = false;
                        entry.Entity.CreatedDate = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Property(x => x.CreatedDate).IsModified = false;
                        entry.Property(x => x.CreatedBy).IsModified = false;
                        entry.Entity.UpdatedDate = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Deleted:
                        entry.Property(x => x.CreatedDate).IsModified = false;
                        entry.Property(x => x.CreatedBy).IsModified = false;
                        entry.State = EntityState.Modified;
                        entry.Entity.Deleted = true;
                        entry.Entity.DeletedDate = DateTimeOffset.UtcNow;
                        break;

                    default:
                        break;
                }
            }
        }

        

        public override int SaveChanges()
        {
            SetAuditEntities();
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}

