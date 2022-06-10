using FlightAcademySchool.Application.Repositories.Common;
using FlightAcademySchool.Domain.Entities.Common;
using FlightAcademySchool.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAcademySchool.Persistence.Repositories.Common
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity>
        where TEntity : BaseEntity
    {
        public DbSet<TEntity> Table => Context.Set<TEntity>();

        protected ProjectDbContext Context { get; }
        public WriteRepository(ProjectDbContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void MultipleDelete(params TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
