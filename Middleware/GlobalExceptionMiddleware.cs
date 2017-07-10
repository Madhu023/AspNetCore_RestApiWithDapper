using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AspNetCore_RestApiWithDapper.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next, ILoggerFactory logger)
        {
            _next = next;
            _logger = logger.CreateLogger("GlobalExceptionMiddleware");
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(0, ex, ex.Message);
            }
        }
    }
}

