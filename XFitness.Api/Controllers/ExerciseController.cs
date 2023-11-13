﻿using Microsoft.AspNetCore.Mvc;

namespace XFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        // GET: api/<ExerciseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExerciseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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