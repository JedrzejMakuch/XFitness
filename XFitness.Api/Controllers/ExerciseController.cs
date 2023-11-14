using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XFitness.Data.Data;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly XFitnessDbContext _context;
        public ExerciseController(XFitnessDbContext context)
        {
            _context = context;
        }

        // GET Exercise by Id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetExerciseById(int id)
        {
            var exercise = await _context.Exercises.FirstOrDefaultAsync(exercise => exercise.ExerciseId == id);
            if(exercise == null)
            {
                return NotFound($"There is not exercise with Id = {id}");
            }

            return Ok(exercise);
        }

        // POST api/<ExerciseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExerciseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExerciseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
