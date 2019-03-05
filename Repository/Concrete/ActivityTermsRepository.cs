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
    public class ActivityTermsRepository : BaseRepository, IEntityRepository<ActivityTerms>
    {
        public async Task<bool> DeleteEntityAsync(ActivityTerms entity)
        {
            if (entity == null)
                return false;

            context.ActivityTerms.Remove(entity);

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

        public async Task<List<ActivityTerms>> GetEntitiesAsync()
        {
            var entities = await context.ActivityTerms.ToListAsync();
            return entities;
        }

        public async Task<ActivityTerms> GetEntityAsync(int id)
        {
            var entity = await context.ActivityTerms.FirstOrDefaultAsync(x => x.ActivityTermsId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(ActivityTerms entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.ActivityTermsId == default(int) ? EntityState.Added : EntityState.Modified;

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
