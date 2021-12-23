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
        public IEnumerable<string> Get()
        {
            return new string[] { "tender1","tender2" };
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "tender";
        }
        [HttpPost]
        public void Post(int id, [FromBody] string tender)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string tender)
        {
        }

    }
}
