using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace API_TEST.Controllers
{

    public class DefaultController : ApiController
    {

        [System.Web.Http.HttpPost]
        [logFilter]
        [AuthenticationFilter]
        public virtual HttpResponseMessage  FirstMethod()
        {
            return Request.CreateErrorResponse(HttpStatusCode.RequestTimeout, " RequestTimeout");
        }

    }
}
