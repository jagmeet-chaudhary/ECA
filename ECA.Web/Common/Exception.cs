using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace ECA.Web.Common
{
    public class BaseException : Exception 
    {
        public Message ExceptionMessage { get; set; }
        public BaseException()
        {
        }
        public BaseException(Message objExceptionMessage)
        {
            ExceptionMessage = objExceptionMessage;
        }


    }
   
    public class ClientErrorHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            
            var objResponse = filterContext.RequestContext.HttpContext.Response;
            filterContext.HttpContext.Response.StatusCode =(int) System.Net.HttpStatusCode.InternalServerError;
            if (filterContext.Exception is BaseException)
            {
                BaseException objBaseException = filterContext.Exception as BaseException;
                
                filterContext.Result = new JsonResult() { Data = new { GeneralMessage = objBaseException.ExceptionMessage.GeneralMessage, SpecificMessage = objBaseException.ExceptionMessage.SpecificMessage } };
            }
            else
            {
                Exception objException = filterContext.Exception;
                filterContext.Result = new JsonResult() { Data = new { GeneralMessage = "", SpecificMessage = objException.Message } };
            }
            
            filterContext.ExceptionHandled = true;

            
        }
    }
}