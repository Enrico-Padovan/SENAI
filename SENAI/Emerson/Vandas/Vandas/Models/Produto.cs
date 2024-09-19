using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vandas.Models
{
    public class Produto
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set;}
    }
}
