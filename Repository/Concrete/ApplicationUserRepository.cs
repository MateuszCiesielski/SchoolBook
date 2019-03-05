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
    public class ApplicationUserRepository : BaseRepository, IEntityRepository<ApplicationUser>
    {
        public async Task<bool> DeleteEntityAsync(ApplicationUser entity)
        {
            if (entity == null)
                return false;

            context.ApplicationUser.Remove(entity);

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

        public async Task<List<ApplicationUser>> GetEntitiesAsync()
        {
            var entities = await context.ApplicationUser.ToListAsync();
            return entities;
        }

        public async Task<ApplicationUser> GetEntityAsync(int id)
        {
            var entity = await context.ApplicationUser.FirstOrDefaultAsync(x => Int32.Parse(x.Id) == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(ApplicationUser entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = Int32.Parse(entity.Id) == default(int) ? EntityState.Added : EntityState.Modified;

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
