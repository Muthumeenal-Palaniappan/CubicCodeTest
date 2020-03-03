using Calcuclator.Business;
using Calculator.API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Calcuclator.Business.Interfaces;
using Calculator.API.Filter;

namespace Calculator.API.Controllers
{
   [CustomExceptionFilter]
    public class SimpleCalculatorController : ApiController
    {
        private readonly ISimpleCalculatorService _simpleCalcService;
        public   SimpleCalculatorController(ISimpleCalculatorService simpleCalcService)
        {
            _simpleCalcService = simpleCalcService;
        }
              
        [HttpPost]
        public IHttpActionResult Add(int start,int amount)
        {
            int result = _simpleCalcService.Add(start, amount);
            return Ok(result);
        }
        [HttpPost]
        public IHttpActionResult Subtract(int start, int amount)
        {
            int result = _simpleCalcService.Subtract(start, amount);
            return Ok(result);
        }
        [HttpPost]
        public IHttpActionResult Multiply(int start, int by)
        {
            int result = _simpleCalcService.Multiply(start, by);
            return Ok(result);
        }
        [HttpPost]
        public IHttpActionResult Divide(int start, int by)
        {
           
            int result = _simpleCalcService.Divide(start, by);
            return Ok(result);
        }

    }
}
