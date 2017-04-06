using SpringHackApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpringHackApp.Controllers
{
    public class ValuesController : ApiController
    {

        public string Index()
        {
            return "This is my default action...";
        }
        // GET api/values
        public string Get()
        {
            return _counter.Number.ToString();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "blah value";
          //  return "< img src = "https://upload.wikimedia.org/wikipedia/bar/thumb/2/27/Hello_Kitty_logo.svg/2000px-Hello_Kitty_logo.svg.png" />";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        static Counter _counter = new Counter();
    }
}
