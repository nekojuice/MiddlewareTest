namespace MiddlewareTest.Middleware;

public class DogMiddleware
{
    private readonly RequestDelegate _next;
    public DogMiddleware(RequestDelegate next) { _next = next; }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("DOG: 3 start");
        await _next(context);
        Console.WriteLine("DOG: 3 end");
    }
}
