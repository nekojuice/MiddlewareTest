using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareTest.Filter
{
    public class NKJActionFilter : Attribute, IActionFilter, IAsyncActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //context.HttpContext.Response.WriteAsync("正在觸發Filter. \r\n");
            Console.WriteLine("正在觸發Filter");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //context.HttpContext.Response.WriteAsync("Filter觸發完畢. \r\n");
            Console.WriteLine("Filter觸發完畢");
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //await context.HttpContext.Response.WriteAsync("(非同步)正在觸發Filter. \r\n");
            Console.WriteLine("(非同步)正在觸發Filter");

            await next();

            //await context.HttpContext.Response.WriteAsync("(非同步)Filter觸發完畢. \r\n");
            Console.WriteLine("(非同步)Filter觸發完畢");
        }
    }
}
