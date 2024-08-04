using Microsoft.EntityFrameworkCore;
using ReenbitApp1.Data;
using ReenbitApp1.Models;
using System;

namespace ReenbitApp1.Services
{
    public class MessageService
    {
        private readonly IDbContextFactory<ReenbitDbContext> _contextFactory;

        public MessageService(IDbContextFactory<ReenbitDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void AddMessage(ChatMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var context = _contextFactory.CreateDbContext();
            context.ChatMessages.Add(message);
            context.SaveChanges();
        }

        public List<ChatMessage> GetChatMessages() 
        {
            using var context = _contextFactory.CreateDbContext();
            return context.ChatMessages.ToList();
        }
    }
}
