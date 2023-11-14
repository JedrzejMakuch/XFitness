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

        //[HttpPost]
        //public async Task<ActionResult<ExerciseDto>> PostExerciseAsync([FromBody] ExercisePayload exercisePayload)
        //{
        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult<ExerciseDto>> UpdateExercise(int id, [FromBody] ExercisePayload exercisePayload)
        //{
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> DeleteExercise(int id)
        //{
        //}
    }
}
