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
    public class ActivityDatesRepository : BaseRepository, IEntityRepository<ActivityDates>
    {
        public async Task<bool> DeleteEntityAsync(ActivityDates entity)
        {
            if (entity == null)
                return false;

            context.ActivityDates.Remove(entity);

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

        public async Task<List<ActivityDates>> GetEntitiesAsync()
        {
            var entities = await context.ActivityDates.ToListAsync();
            return entities;
        }

        public async Task<ActivityDates> GetEntityAsync(int id)
        {
            var entity = await context.ActivityDates.FirstOrDefaultAsync(x => x.ActivityDatesId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(ActivityDates entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.ActivityDatesId == default(int) ? EntityState.Added : EntityState.Modified;

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
