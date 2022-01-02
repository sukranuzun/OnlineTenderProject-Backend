using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TenderDetailDto : IDto
    {
        public int TenderId { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public double UnitPrice { get; set; }
    }
}
