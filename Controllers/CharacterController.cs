using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> knights = new List<Character>(){
            new Character(),
            new Character{Name="Sam"}
        };

        [HttpGet("all")]
        public ActionResult<List<Character>> Get(){
            return Ok(knights);
        }

        [HttpGet("single")]
        public ActionResult<Character> GetSingle(){
            return Ok(knights[0]);
        }
    }
}