using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World¡");
        }
  
    }
}

