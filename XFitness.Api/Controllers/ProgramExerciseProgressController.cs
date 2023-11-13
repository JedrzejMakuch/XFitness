using Microsoft.AspNetCore.Mvc;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramExerciseProgressController : ControllerBase
    {
        // GET: api/<ProgramExerciseProgressController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProgramExerciseProgressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProgramExerciseProgressController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProgramExerciseProgressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProgramExerciseProgressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
