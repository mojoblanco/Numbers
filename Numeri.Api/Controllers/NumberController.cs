using System;
using Microsoft.AspNetCore.Mvc;
using Numbers.core;

namespace Numeri.Api.Controllers
{
    [Route("api/[controller]")]
    public class NumberController : Controller
    {
        public IActionResult GetAll()
        {
            var number = new Number();
            number.Data = "This is a sure shot";
            //var number = "Lol";

            return new ObjectResult(number);
        }

        [HttpGet("{id}/{name}")]
        public string Get(int id, string name)
        {
            var str = $"Id is {id} and name is {name}";
            return str;
        }
    }
}
