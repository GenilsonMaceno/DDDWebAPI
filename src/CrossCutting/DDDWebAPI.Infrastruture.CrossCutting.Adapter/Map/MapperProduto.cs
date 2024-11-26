using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperProduto : IMapperProduto
    {
        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {

                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Valor = item.Valor

                };

                produtoDTOs.Add(produtoDTO);
            }


            return produtoDTOs;
        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id
   ,
                Nome = produto.Nome
   ,
                Valor = produto.Valor
            };

            return produtoDTO;
        }

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {

                Id = produtoDTO.Id.Value,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor

            };

            return produto;
        }
    }
}
