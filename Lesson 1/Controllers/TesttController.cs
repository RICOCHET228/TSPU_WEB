using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesttController : ControllerBase
    {
        [HttpGet("{size}")]
        public IActionResult Get([FromRoute] int size)
        {
            //size = Math.Abs(size);
            if (size < 0)
            {
                return BadRequest();
            }

            var rng = new Random();
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i]=rng.Next(90,790);
            }
            return Ok(nums);
        }
    }
}
