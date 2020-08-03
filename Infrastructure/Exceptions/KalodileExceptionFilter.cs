using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace kalodile.Infrastructure.Exceptions
{
    public class KalodileExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            context.HttpContext.Response.StatusCode = context.Exception switch
            {
                BadRequestException _ => (int)HttpStatusCode.BadRequest,
                NotFoundException _ => (int)HttpStatusCode.NotFound,
                InternalServerErrorException _ => (int)HttpStatusCode.InternalServerError,
                _ => (int)HttpStatusCode.InternalServerError,
            };

            context.Result = new JsonResult(new
            {
                ErrorCode = "", // todo: for multilanguage support
                context.Exception.Message
            });
        }
    }
}
