using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Tender : IEntity
    {
        public int TenderId { get; set; }
        public int AdminId { get; set; }
        public int CategoryId { get; set; }
        public double UnitPrice { get; set; }
        public bool Active { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }

    }
}
