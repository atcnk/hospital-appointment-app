﻿using Core.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>, IAsyncRepository<TEntity>
        where TContext : DbContext
        where TEntity : Entity<int>
    {
		protected readonly TContext Context;
        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }
        public IQueryable<TEntity> Query() => Context.Set<TEntity>();

        public void Add(TEntity entity)
        {
            Context.Add(entity);
            entity.CreatedDate = DateTime.UtcNow;
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }

        public void SoftDelete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.UtcNow;
            Context.Update(entity);
            Context.SaveChanges();
        }
        public TEntity? Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();

            if (include != null)
                data = include(data);

            return data.FirstOrDefault(predicate);
        }

        public IPaginate<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,    int index = 0,
            int size = 10,
            bool enableTracking = true
        )
        {
            IQueryable<TEntity> queryable = Query();

            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (include != null)
                queryable = include(queryable);

            return queryable.ToPaginate(index, size);
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
            entity.UpdatedDate = DateTime.UtcNow;
            Context.SaveChanges();
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context.AddAsync(entity);
            entity.CreatedDate = DateTime.UtcNow;
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.UtcNow;
            Context.Update(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();

            if (include != null)
                data = include(data);

            return await data.FirstOrDefaultAsync(predicate);
        }
        public async Task<IPaginate<TEntity>> GetListAsync(
           Expression<Func<TEntity, bool>>? predicate = null,
           Func<IQueryable<TEntity>,
           IIncludableQueryable<TEntity, object>>? include = null,
           int index = 0,
           int size = 10,
           CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();

            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (include != null)
                queryable = include(queryable);

            return await queryable.ToPaginateAsync(index, size, from: 0, cancellationToken);
        }
        public async Task UpdateAsync(TEntity entity)
        {
            Context.Update(entity);
            entity.UpdatedDate = DateTime.UtcNow;
            await Context.SaveChangesAsync();
        }
    }
}
