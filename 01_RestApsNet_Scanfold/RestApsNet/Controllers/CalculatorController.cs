﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApsNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber)&&IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

                //var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                //return Ok(sum.ToString());

                //var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                //return Ok(sum.ToString());

                //var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                //return Ok(sum.ToString());



            }
            return BadRequest("Invalid Input");
       
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool IsNumber = double.TryParse(
                strNumber, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return IsNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
                {

                return decimalValue;

                }
            return 0;
        }

        
    }
}
