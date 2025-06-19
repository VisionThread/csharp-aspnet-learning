using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace app2_exception
{
    public class Myexception : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            await httpContext.Response.WriteAsync();
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return true;
        }
    }
}
