using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace API_TEST.Controllers
{
    public class AuthenticationFilterAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //var identity = fetchFromHeader(actionContext);
            if (actionContext == null)
            {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    return;
            }
            else
            {
                var authenticationString = actionContext.Request.Headers.Authorization.Parameter;
                var originalString = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));

                // Get username and password  
                var usrename = originalString.Split(':')[0];
                var password = originalString.Split(':')[1];

                if (usrename == "prathesh" && password == "123")
                {

                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }

            base.OnAuthorization(actionContext);
        }
    }
}