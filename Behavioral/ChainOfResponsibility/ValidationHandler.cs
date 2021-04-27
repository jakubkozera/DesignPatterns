using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("ValidationHandler");

            if (requestContext.Request.EntityId > 100)
            {
                _next.Handle(requestContext);
                return;

            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Validation error: EntityId must be greater than 100";
        }
    }
}
