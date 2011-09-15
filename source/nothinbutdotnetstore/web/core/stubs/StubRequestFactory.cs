﻿using System.Web;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : ICreateRequests
    {
        public IContainRequestInformation create_request_from(HttpContext an_incoming_httpcontext)
        {
            return new StubRequest();
        }

        class StubRequest : IContainRequestInformation
        {
        }
    }
}