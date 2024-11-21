using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Application.Interfaces;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWebAPI.Application.Service
{
    public class ApplicationServiceProduto : IDisposable, IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto)
        {
            _serviceProduto = serviceProduto;
        }

        public void Add(ProdutoDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProdutoDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProdutoDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ProdutoDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
