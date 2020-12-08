﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCORSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {Message = "Hi there!"});
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok(new {Message = "Sample Controller: POST OK"});
        }
    }
}
