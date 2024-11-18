using DDDWebAPI.Domain.Core.Interfaces.Repositories;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWebAPI.Domain.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
    }
}
