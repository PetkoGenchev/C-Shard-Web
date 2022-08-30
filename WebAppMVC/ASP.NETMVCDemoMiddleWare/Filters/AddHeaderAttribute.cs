using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP.NETMVCDemoMiddleWare.Filters
{
    public class AddHeaderAttribute : ActionFilterAttribute
    {
        public string Name { get; init; }

        public string Value { get; init; }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add($"BeforeAction-{this.Name}", this.Value);


            base.OnActionExecuting(context);
        }


        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add($"AfterAction-{this.Name}", this.Value);

            base.OnActionExecuted(context);
        }
    }
}
