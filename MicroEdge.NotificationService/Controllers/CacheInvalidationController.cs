using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroEdge.NotificationService
{
    public class CacheInvalidationController : HubController<OutcomesHub>
    {
        // POST api/<controller>
        public bool Post([FromBody]CacheInvalidation notification)
        {
            Hub.Clients.All.invalidateCacheKey(notification.CacheKey);
            return true;
        }
    }
}