using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class AddTenController : ApiController
    {
        //GET api/AddTen/5
        //input : integer
        //output: Returns 10 more than the integer input
        public int Get(int id)
        {
            return id+10;
        }
    }
}
