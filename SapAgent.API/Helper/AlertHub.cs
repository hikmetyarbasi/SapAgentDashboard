﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SapAgent.API.Helper
{
    public class AlertHub : Hub<ITypedHubClient>
    {
        public async Task SendMessage(string user, string message)
        {

        }

    }
}
