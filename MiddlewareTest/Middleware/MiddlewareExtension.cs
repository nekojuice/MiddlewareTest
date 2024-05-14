namespace MiddlewareTest.Middleware
{
    public static class MiddlewareExtension
    {
        public static void UseCATCATMiddleware(this IApplicationBuilder app) 
        {
            app.UseMiddleware<CatMiddleware>();
            Console.WriteLine("CAT: UseCATCATMiddleware 2");
        }
    }
}
