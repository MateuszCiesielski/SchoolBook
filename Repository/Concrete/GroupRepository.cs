using Model.Entities;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    public class GroupRepository : BaseRepository, IEntityRepository<Group>
    {
        public async Task<bool> DeleteEntityAsync(Group entity)
        {
            if (entity == null)
                return false;

            context.Group.Remove(entity);

            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public async Task<List<Group>> GetEntitiesAsync()
        {
            var entities = await context.Group.ToListAsync();
            return entities;
        }

        public async Task<Group> GetEntityAsync(int id)
        {
            var entity = await context.Group.FirstOrDefaultAsync(x => x.GroupId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(Group entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.GroupId == default(int) ? EntityState.Added : EntityState.Modified;

                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
