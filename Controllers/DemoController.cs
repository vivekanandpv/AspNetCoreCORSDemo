using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace AspNetCoreCORSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Public")]  //  Overrides global policy. Can also be applied to method level
    public class DemoController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new {message = "Demo Controller: OK"});
        }
    }
}
