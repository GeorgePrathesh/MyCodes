using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_TEST.Controllers
{
    public class orderSearchController : ApiController
    {
        [System.Web.Http.HttpPost]
        [logFilter]
        [AuthenticationFilter]
        public virtual HttpResponseMessage S()
        {
            return Request.CreateErrorResponse(HttpStatusCode.RequestTimeout, " RequestTimeout");
        }
    }
}
