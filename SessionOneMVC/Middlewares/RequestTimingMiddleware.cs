using System.Diagnostics;

namespace SessionOneMVC.Middlewares
{
    public class RequestTimingMiddleware
    {

        private readonly RequestDelegate _next;
        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var watch = new Stopwatch();
            watch.Start();
            await _next(context);
            watch.Stop();
            Console.WriteLine($"{context.Request.Path}  ==> {watch.ElapsedMilliseconds} ms");
        }
    }
}
