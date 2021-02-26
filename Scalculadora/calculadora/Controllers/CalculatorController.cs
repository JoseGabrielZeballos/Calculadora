using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Multiply")]
        public float Multiply([FromHeader] float numa, [FromHeader] float numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Divide")]
        public float Divide([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }
        [HttpPost]
        [Route("Subtraction")]
        public float Subtration([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
    }
}
