using System.Web.Http;
using CroweTest.Models;

namespace CroweTest.Controllers
{
    public class MessageToWorldApiController : ApiController
    {
        // GET api/<controller>
        // Gets the default message to the world
        public MessageToWorldModel Get()
        {
            return new MessageToWorldModel { Id = 1, Message = "Hello World!"};
        }

        // GET api/<controller>/5
        // Really this would go to a database to retrieve a message to the world,
        // but for this test, it just returns one
        public MessageToWorldModel Get(int id)
        {
            return new MessageToWorldModel { Id = id, Message = "Hello World!" };
        }

        // POST api/<controller>
        // this is the api that we would use to save a new message to the world
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        // this is the api that we would use to update an existing message to the world
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        // this is the api that we would use to delete an existing message to the world
        public void Delete(int id)
        {
        }
    }
}