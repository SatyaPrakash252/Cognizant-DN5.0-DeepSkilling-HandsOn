using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiHandsOn.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "ErrorLog.txt");

            File.AppendAllText(filePath,
                $"{DateTime.Now} : {context.Exception.Message}{Environment.NewLine}");

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}