using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Client : IEntity
    {
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}
