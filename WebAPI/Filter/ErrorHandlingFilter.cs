using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace WebAPI.Filter
{
    public class ErrorHandlingFilter : IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(new
            {
                Error = context.Exception.Message
            })
            {
                StatusCode = 500
            };
        }
    }
}
