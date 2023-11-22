using Microsoft.AspNetCore.Mvc;
using XFitness.Api.Services.Services.Contracts;
using XFitness.Models.Dtos;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramExerciseProgressController : ControllerBase
    {
        private readonly IProgramExerciseProgressService _programExerciseProgressService;
        public ProgramExerciseProgressController(IProgramExerciseProgressService programExerciseProgressService)
        {
            _programExerciseProgressService = programExerciseProgressService;
        }

        //[HttpGet]
        //public async Task<IEnumerable<ProgramExerciseProgressDto>> GetProgramExerciseProgressList()
        //{
        //    var programExerciseProgressList = await _programExerciseProgressService.GetProgramExerciseProgressList();
            
        //}

        // GET api/<ProgramExerciseProgressController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProgramExerciseProgressController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProgramExerciseProgressController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProgramExerciseProgressController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
