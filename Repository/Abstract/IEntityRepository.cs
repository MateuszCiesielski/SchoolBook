using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface IEntityRepository<Entity>
    {
        Task<Entity> GetEntityAsync(int id);
        Task<List<Entity>> GetEntitiesAsync();
        Task<bool> SaveEntityAsync(Entity entity);
        Task<bool> DeleteEntityAsync(Entity entity);
    }
}
