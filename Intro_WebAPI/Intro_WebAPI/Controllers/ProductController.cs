using Intro_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace Intro_WebAPI.Controllers
{
   
    public class ProductController : ApiController
    {
       
        // GET: api/Product
        public HttpResponseMessage Get()
        {
            var context = new PMSEntities();
            var rs = context.Products.ToList();
            var data = JsonConvert.SerializeObject(rs);
            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            return res;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
        [Route("api/Product/Names")]
        [HttpGet]
        public IEnumerable<string> GetProductNames()
        {
            PMSEntities context = new PMSEntities();
            IEnumerable<string> names = context.Products.Select(e => e.Name).ToList();
            return names;
        }
    }
}
