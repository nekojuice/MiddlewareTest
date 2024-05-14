namespace MiddlewareTest.Middleware;

public class CatMiddleware
{
    private readonly RequestDelegate _next;
    public CatMiddleware(RequestDelegate next) {  _next = next; }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("CAT: 2 start");
        await _next(context);
        Console.WriteLine("CAT: 2 end");
    }
}
