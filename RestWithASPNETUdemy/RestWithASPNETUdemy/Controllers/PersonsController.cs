using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Functions;

using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (MyMath.IsNumeric(firstNumber) && MyMath.IsNumeric(secondNumber))
            {
                var sum = MyMath.ConvertToDecimal(firstNumber) + MyMath.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // GET api/values/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (MyMath.IsNumeric(firstNumber) && MyMath.IsNumeric(secondNumber))
            {
                var subtraction = MyMath.ConvertToDecimal(firstNumber) - MyMath.ConvertToDecimal(secondNumber);
                return Ok(subtraction.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // GET api/values/division/5/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (MyMath.IsNumeric(firstNumber) && MyMath.IsNumeric(secondNumber))
            {
                var division = MyMath.ConvertToDecimal(firstNumber) / MyMath.ConvertToDecimal(secondNumber);
                return Ok(division.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // GET api/values/multiplication/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (MyMath.IsNumeric(firstNumber) && MyMath.IsNumeric(secondNumber))
            {
                var multiplication = MyMath.ConvertToDecimal(firstNumber) * MyMath.ConvertToDecimal(secondNumber);
                return Ok(multiplication.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // GET api/values/average/5/5
        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {
            if (MyMath.IsNumeric(firstNumber) && MyMath.IsNumeric(secondNumber))
            {
                var average = (MyMath.ConvertToDecimal(firstNumber) + MyMath.ConvertToDecimal(secondNumber)) / 2;
                return Ok(average.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // GET api/values/square-root/5/5
        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number)
        {
            if (MyMath.IsNumeric(number))
            {
                var squareRoot = Math.Sqrt((double)MyMath.ConvertToDecimal(number));
                return Ok(squareRoot.ToString());
            }

            return BadRequest("Invalid Input");
        }

    }
}
