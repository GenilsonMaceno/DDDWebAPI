using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public interface IMapperCliente
    {
        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);
    }
}
