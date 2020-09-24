using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting/5
        public string Get(int id)
        {
            return "Greetings to "+id+" people!";
        }

        // POST api/Greeting
        public string Post()
        {
            return "Hello World!";
        }
    }
}
