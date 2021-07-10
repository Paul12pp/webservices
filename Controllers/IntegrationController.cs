using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServices.Interface;
using WebServices.Model;

namespace WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        private readonly IIntegration _context;
        public IntegrationController(IIntegration context)
        {
            _context = context;
        }
        [HttpGet("getempleados")]
        public Task<IEnumerable<Empleados>> Get()
        {
            return  _context.GetEmpleados();
        }
        [HttpPost("post")]
        public async Task<IActionResult> Post(IntegrationInputDto model)
        {
            try
            {
                await _context.AddResource(model);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
