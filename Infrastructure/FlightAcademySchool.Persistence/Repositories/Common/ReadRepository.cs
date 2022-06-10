using FlightAcademySchool.Application.Repositories.Common;
using FlightAcademySchool.Domain.Entities.Common;
using FlightAcademySchool.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightAcademySchool.Persistence.Repositories.Common
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity>
        where TEntity : BaseEntity
    {
        public DbSet<TEntity> Table => Context.Set<TEntity>();

        protected ProjectDbContext Context { get; }
        public ReadRepository(ProjectDbContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public TEntity GetFirst(Expression<Func<TEntity, bool>> filter, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
