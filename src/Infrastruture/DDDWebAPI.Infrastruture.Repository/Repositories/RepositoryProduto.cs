using DDDWebAPI.Domain.Core.Interfaces.Repositories;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWebAPI.Infrastruture.Repository.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SQLContext _sqlContext;
        public RepositoryProduto(SQLContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
