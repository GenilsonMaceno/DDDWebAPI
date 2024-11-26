using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperCliente : IMapperCliente
    {

        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {


                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Sobrenome = item.Sobrenome
                   ,
                    Email = item.Email
                };



                clienteDTOs.Add(clienteDTO);

            }

            return clienteDTOs;
        }

        public ClienteDTO MapperToDTO(Cliente cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = cliente.Id
               ,
                Nome = cliente.Nome
               ,
                Sobrenome = cliente.Sobrenome
               ,
                Email = cliente.Email
            };

            return clienteDTO;
        }

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id.Value
               ,
                Nome = clienteDTO.Nome
               ,
                Sobrenome = clienteDTO.Sobrenome
               ,
                Email = clienteDTO.Email
            };

            return cliente;
        }
    }
}
