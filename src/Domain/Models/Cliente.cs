using System;

namespace DDDWebAPI.Domain.Models;

public class Cliente : Base
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public Datetime DataCadastro { get; set; }
    public bool Ativo { get; set; }
}