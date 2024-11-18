using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWebAPI.Domain.Models
{
    public class Produto : Base
    {
        public string Nome { get; set; }

        public Decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
