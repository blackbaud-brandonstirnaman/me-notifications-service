using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MicroEdge.NotificationService
{
    public class OutcomesHub : Hub
    {
        public void InvalidateCacheKeyOnAllClients(string cacheKey)
        {
            Clients.AllExcept(Context.ConnectionId).invalidateCacheKey(cacheKey);
        }
    }
}