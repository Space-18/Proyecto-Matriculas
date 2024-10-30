using Matriculas.Domain.Entities.Commons;
using Microsoft.EntityFrameworkCore;

namespace Matriculas.Persistence.Helper
{
    internal static class AuditHelper
    {
        public static void ApplyAuditInformation(ApplicationDBContext context)
        {
            foreach (var item in context.ChangeTracker.Entries<BaseModel>())
            {
                switch (item.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        item.Entity.IsActive = false;
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdateDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        item.Entity.CreateDate = DateTime.Now;
                        item.Entity.IsActive = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
