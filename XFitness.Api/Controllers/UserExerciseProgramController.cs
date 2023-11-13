using Microsoft.AspNetCore.Mvc;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExerciseProgramController : ControllerBase
    {
        // GET: api/<UserExerciseProgramController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserExerciseProgramController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserExerciseProgramController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserExerciseProgramController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserExerciseProgramController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
