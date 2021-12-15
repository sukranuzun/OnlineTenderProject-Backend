using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TendersController : ControllerBase
    {
        private DataContext _context;

        public TendersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetTenders()
        {
            var tenders = _context.Tender.ToList();
            return Ok(tenders);
        }
    }
}
