using Business.Abstract;
using Entities.Concrete;
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
    public class BidClientsController : ControllerBase
    {
        IBidClientService _bidClientService;
        public BidClientsController(IBidClientService bidService)
        {
            _bidClientService = bidService;

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bidClientService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _bidClientService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(BidClient bidClient)
        {
            var result = _bidClientService.Add(bidClient);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(BidClient bidClient)
        {
            var result = _bidClientService.Update(bidClient);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
