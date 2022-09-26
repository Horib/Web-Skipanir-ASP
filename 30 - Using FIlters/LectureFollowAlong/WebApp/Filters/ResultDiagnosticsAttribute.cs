using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Filters
{
    public class ResultDiagnosticsAttribute : Attribute, IResultFilter
    {

        public void OnResultExecuting(
                ResultExecutingContext context)
        {

            if (context.HttpContext.Request.Query.ContainsKey("diag"))
            {
                Dictionary<string, string?> diagData =
                    new Dictionary<string, string?> {
                        {"Result type", context.Result.GetType().Name }
                    };
                if (context.Result is ViewResult vr)
                {
                    diagData["View Name"] = vr.ViewName;
                    diagData["Model Type"] = vr.ViewData?.Model?.GetType().Name;
                    diagData["Model Data"] = vr.ViewData?.Model?.ToString();
                }
                context.Result = new ViewResult()
                {
                    ViewName = "/Views/Shared/Message.cshtml",
                    ViewData = new ViewDataDictionary(
                                       new EmptyModelMetadataProvider(),
                                       new ModelStateDictionary())
                    {
                        Model = diagData
                    }
                };
            }
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }
    }
}
