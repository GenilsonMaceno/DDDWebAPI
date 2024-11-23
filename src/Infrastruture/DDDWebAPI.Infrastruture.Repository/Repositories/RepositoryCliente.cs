using DDDWebAPI.Domain.Core.Interfaces.Repositories;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastruture.Repository.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SQLContext _sqlContext;

        public RepositoryCliente(SQLContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
