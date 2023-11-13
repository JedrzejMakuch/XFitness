using Microsoft.AspNetCore.Mvc;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPsychicalParametersController : ControllerBase
    {
        // GET: api/<UserPsychicalParametersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserPsychicalParametersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserPsychicalParametersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserPsychicalParametersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserPsychicalParametersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
