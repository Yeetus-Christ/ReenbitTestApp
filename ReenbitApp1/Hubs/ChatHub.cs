﻿using Microsoft.AspNetCore.SignalR;

namespace ReenbitApp1.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
