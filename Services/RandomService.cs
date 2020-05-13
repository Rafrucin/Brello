using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brello.Services
{
    public class RandomService
    {
        public Guid RandomId { get; set; } = Guid.NewGuid();
    }
}
