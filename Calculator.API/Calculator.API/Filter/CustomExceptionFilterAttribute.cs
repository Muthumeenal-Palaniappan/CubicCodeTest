using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Calculator.API.Filter
{
    public class CustomExceptionFilterAttribute: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var exception = actionExecutedContext.Exception;
            HttpResponseMessage response;
            if (exception is DivideByZeroException)
                response = new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest, Content = new StringContent(exception.Message) };
            else
                response = new HttpResponseMessage() { StatusCode = HttpStatusCode.InternalServerError, Content = new StringContent(exception.Message) };
            throw new HttpResponseException(response);
        }
    }
} 