using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos);

        ProdutoDTO MapperToDTO(Produto produto);
    }
}
