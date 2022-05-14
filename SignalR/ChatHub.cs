﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await Clients.All.SendAsync("Send", message);
        }
    }
}
