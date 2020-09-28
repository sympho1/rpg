using Microsoft.AspNetCore.Mvc;
using rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        public static Character character = new Character();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(character);
        }
    }
}
