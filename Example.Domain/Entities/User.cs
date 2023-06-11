using Example.Domain.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
        public IEnumerable<Game> UserGames { get; set; }

    }
}
