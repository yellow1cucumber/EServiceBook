using Domain.Core;

using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Repository<TEntity> where TEntity : Entity
    {
        protected DbSet<TEntity> entities;
        protected Context context;

        public Repository(Context context) {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }

        #region READ
        public IQueryable<TEntity> GetAllAsync()
        {
            return this.entities.AsQueryable();
        }
        public async Task<TEntity> GetAsync(int id)
        {
            return await this.entities.FirstOrDefaultAsync(entities => entities.Id == id)
                ?? throw new IndexOutOfRangeException();
        }
        #endregion

        #region ADD
        public async Task AddAsync(TEntity entity)
        {
            await this.entities.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }
        #endregion

        #region UPDATE
        public async Task UpdateAsync(TEntity entity)
        {
            this.context.Attach(entity);
            this.context.Entry(entity).Property(p => p.Id).IsModified = true;
            await this.context.SaveChangesAsync();
        }
        #endregion

        #region REMOVE
        public async Task RemoveAsync(int id)
        {
            var target = this.GetAsync(id);
            this.context.Remove(target);
            await this.context.SaveChangesAsync();
        }
        #endregion
    }
}
