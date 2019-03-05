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
    public class AttendanceRepository : BaseRepository, IEntityRepository<Attendance>
    {
        public async Task<bool> DeleteEntityAsync(Attendance entity)
        {
            if (entity == null)
                return false;

            context.Attendance.Remove(entity);

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

        public async Task<List<Attendance>> GetEntitiesAsync()
        {
            var entities = await context.Attendance.ToListAsync();
            return entities;
        }

        public async Task<Attendance> GetEntityAsync(int id)
        {
            var entity = await context.Attendance.FirstOrDefaultAsync(x => x.AttendanceId == id);
            return entity;
        }

        public async Task<bool> SaveEntityAsync(Attendance entity)
        {
            if (entity == null) return false;

            try
            {
                context.Entry(entity).State = entity.AttendanceId == default(int) ? EntityState.Added : EntityState.Modified;

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
