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
    public class PersonGroupRepository : BaseRepository, IEntityRepository<PersonGroup>
    {
        public async Task<bool> DeleteEntityAsync(PersonGroup entity)
        {
            if (entity == null)
                return false;

            context.PersonGroup.Remove(entity);

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

        public async Task<List<PersonGroup>> GetEntitiesAsync()
        {
            var entities = await context.PersonGroup.ToListAsync();
            return entities;
        }

        public async Task<PersonGroup> GetEntityAsync(int id)
        {
            var entity = await context.PersonGroup.FirstOrDefaultAsync(x => x.PersonGroupId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(PersonGroup entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.PersonGroupId == default(int) ? EntityState.Added : EntityState.Modified;

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
