using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Bank.midaleWare
{
    public class shabatMidaleWare
    {
        private readonly RequestDelegate _next;

        public shabatMidaleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("the middleware work!");
            var isSaturday = DateTime.Today.DayOfWeek == DayOfWeek.Saturday;
            if (isSaturday)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                Console.WriteLine("shabat!!!!!!!");
                return;
            }
            await _next(context);
        }
    }
}
