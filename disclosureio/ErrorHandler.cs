using disclosureio.ViewModels;
using Nancy;
using Nancy.ErrorHandling;
using Nancy.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio
{
    public class ErrorHandler : DefaultViewRenderer, IStatusCodeHandler
    {
        public ErrorHandler(IViewFactory factory) : base(factory) { }

        public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
        {
            return false;
            /*return statusCode == HttpStatusCode.NotFound
            || statusCode == HttpStatusCode.InternalServerError
            || statusCode == HttpStatusCode.Forbidden
            || statusCode == HttpStatusCode.Unauthorized;*/
        }

        public void Handle(HttpStatusCode statusCode, NancyContext context)
        {
            var response = RenderView(context, "Error", new ErrorViewModel { StatusCode = statusCode });
            response.StatusCode = statusCode;
            context.Response = response;
        }
    }
}
