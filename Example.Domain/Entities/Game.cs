using Example.Domain.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Entities
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public GameType Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
