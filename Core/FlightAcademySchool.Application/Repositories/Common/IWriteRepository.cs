using FlightAcademySchool.Domain.Entities.Common;

namespace FlightAcademySchool.Application.Repositories.Common
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void MultipleDelete(params TEntity[] entities);
        int SaveChanges();
    }
}
