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
    public class UserPersonRepository : BaseRepository, IEntityRepository<UserPerson>
    {
        public async Task<bool> DeleteEntityAsync(UserPerson entity)
        {
            if (entity == null)
                return false;

            context.UserPerson.Remove(entity);

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

        public async Task<List<UserPerson>> GetEntitiesAsync()
        {
            var entities = await context.UserPerson.ToListAsync();
            return entities;
        }

        public async Task<UserPerson> GetEntityAsync(int id)
        {
            var entity = await context.UserPerson.FirstOrDefaultAsync(x => x.UserPersonId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(UserPerson entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.UserPersonId == default(int) ? EntityState.Added : EntityState.Modified;

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
