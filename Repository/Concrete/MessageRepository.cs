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
    public class MessageRepository : BaseRepository, IEntityRepository<Message>
    {
        public async Task<bool> DeleteEntityAsync(Message entity)
        {
            if (entity == null)
                return false;

            context.Message.Remove(entity);

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

        public async Task<List<Message>> GetEntitiesAsync()
        {
            var entities = await context.Message.ToListAsync();
            return entities;
        }

        public async Task<Message> GetEntityAsync(int id)
        {
            var entity = await context.Message.FirstOrDefaultAsync(x => x.MessageId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(Message entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.MessageId == default(int) ? EntityState.Added : EntityState.Modified;

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
