using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace git_operate.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public class Progrem 
        {
            [HttpGet]
            public string TestGet() 
            {

                return "2022勇士总冠军。";
            
            }

            public int Id { get; set; }

            public DateTime Name { get; }

        }
    }
}
