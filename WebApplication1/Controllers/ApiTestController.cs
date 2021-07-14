using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    
    [ApiController]
    public class ApiTestController : ControllerBase
    {
        [Route("")]
        public async Task<ActionResult<string>> Get()
        {
            return await Task.FromResult(new ActionResult<string>("fuck"));
        }

    }
}
