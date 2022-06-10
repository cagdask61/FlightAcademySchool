using FlightAcademySchool.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightAcademySchool.Application.Repositories.Common
{
    public interface IReadRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = false);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity,bool>> filter,bool tracking = false);

        TEntity GetSingle(Expression<Func<TEntity, bool>> filter, bool tracking = false);
        TEntity GetFirst(Expression<Func<TEntity, bool>> filter, bool tracking = false);

    }
}
