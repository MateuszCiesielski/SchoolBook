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
    public class PersonRepository : BaseRepository, IEntityRepository<Person>
    {
        public async Task<bool> DeleteEntityAsync(Person entity)
        {
            if (entity == null)
                return false;

            context.Person.Remove(entity);

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

        public async Task<List<Person>> GetEntitiesAsync()
        {
            var entities = await context.Person.ToListAsync();
            return entities;
        }

        public async Task<Person> GetEntityAsync(int id)
        {
            var entity = await context.Person.FirstOrDefaultAsync(x => x.PersonId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(Person entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.PersonId == default(int) ? EntityState.Added : EntityState.Modified;

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
