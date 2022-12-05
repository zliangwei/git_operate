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

            [HttpGet]
            public string Warriors()
            {
                return "2022-05-27 西决最后一场";
            }

            public int Id { get; set; }

            public DateTime Name { get; }

            public class Person
            {
            
            }

            public class Student : Person
            {
            
            }

            //里氏替换
            Person person = new Student();

        }
    }
}
