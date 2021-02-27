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
        //
        [HttpGet]
        [Route("Add")]
        public int Add2( int numa, int numb)
        {
            return numa + numb;
        }
        //
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }
        //
        [HttpGet]
        [Route("Multiply")]
        public int Multiply2( int numa,  int numb)
        {
            return numa * numb;
        }
        //
        [HttpPost]
        [Route("Divide")]
        public int Divide([FromHeader] int numa, [FromHeader] int numb)
        {
            if (numb == 0)
                return 0;
            return numa / numb;
        }
        //
        [HttpGet]
        [Route("Divide")]
        public int Divide2(int numa,int numb)
        {
            if (numb == 0)
                return 0;
            return numa / numb;
        }
        //
        [HttpPost]
        [Route("Subtraction")]
        public int Subtration([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
        //
        [HttpGet]
        [Route("Subtraction")]
        public int Subtration2(int numa, int numb)
        {
            return numa - numb;
        }
        //
    }
}
