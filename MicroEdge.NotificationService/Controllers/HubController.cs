using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MicroEdge.NotificationService
{
    public abstract class HubController<T> : ApiController
        where T : Hub
    {
        public IHubContext Hub
        {
            get
            {
                if (hub == null)
                    hub = GlobalHost.ConnectionManager.GetHubContext<T>();

                return hub;
            }
        }

        IHubContext hub;
    }
}