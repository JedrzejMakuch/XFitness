using Microsoft.AspNetCore.Mvc;
using XFitness.Api.Extension;
using XFitness.Api.Services.Services.Contracts;
using XFitness.Models.Dtos;
using XFitness.Models.Payloads;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetExerciseById(int id)
        {
            var exercise = await _exerciseService.GetExerciseByIdAsync(id);
            if (exercise == null)
            {
                return NotFound($"There is not exercise with Id = {id}");
            }
            else
            {
                var exerciseDto = exercise.ConvertToDto();
                return Ok(exerciseDto);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ExerciseDto>> PostExerciseAsync([FromBody] ExercisePayload exercisePayload)
        {
            if(exercisePayload == null)
            {
                return NotFound();
            }

            var exercise = await _exerciseService.CreateExercideAsync(exercisePayload);
            var exerciseDto = exercise.ConvertToDto();

            return Ok(exerciseDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ExerciseDto>> UpdateExercise(int id, [FromBody] ExercisePayload exercisePayload)
        {
            if(id == 0)
            {
                return BadRequest("Id canot be 0");
            }

            var exerciseDto = await _exerciseService.GetExerciseByIdAsync(id);

            if(exerciseDto == null)
            {
                return NotFound($"There is not exercise with Id = {id}");
            }

            if (exercisePayload == null)
            {
                return NotFound();
            }

            var exercise = await _exerciseService.UpdateExercise(id, exercisePayload);

            return Ok(exercise);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteExercise(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id canot be 0");
            }

            var exerciseDto = await _exerciseService.GetExerciseByIdAsync(id);

            if (exerciseDto == null)
            {
                return NotFound($"There is not exercise with Id = {id}");
            }

            await _exerciseService.DeleteExerciseAsync(id);
            return Ok();
        }
    }
}
