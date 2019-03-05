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
    public class MessageReceiverRepository : BaseRepository, IEntityRepository<MessageReceiver>
    {
        public async Task<bool> DeleteEntityAsync(MessageReceiver entity)
        {
            if (entity == null)
                return false;

            context.MessageReceiver.Remove(entity);

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

        public async Task<List<MessageReceiver>> GetEntitiesAsync()
        {
            var entities = await context.MessageReceiver.ToListAsync();
            return entities;
        }

        public async Task<MessageReceiver> GetEntityAsync(int id)
        {
            var entity = await context.MessageReceiver.FirstOrDefaultAsync(x => x.MessageReceiverId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(MessageReceiver entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.MessageReceiverId == default(int) ? EntityState.Added : EntityState.Modified;

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
