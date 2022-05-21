using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Percistence;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Messages.Any()) return;
            
            var messageslist = new List<Message>
            {
                new Message
                {
                    Content = "Whatever dude...",
                    By = "Who ever",
                    Date = DateTime.Now,

                },
                new Message
                {
                    Content = "What do you mean?",
                    By = "What man",
                    Date = DateTime.Now,
                },
                new Message
                {
                   Content = "I know what I mean!",
                   By = "Know man",
                   Date = DateTime.Now,
                },
                new Message
                {
                    Content = "I don't know what I mean",
                    By = "Who ever",
                    Date = DateTime.Now.AddHours(1)
                },
                new Message
                {
                    Content = "Ok man",
                    By = "Mr Ok",
                    Date = DateTime.Now.AddHours(1.5)
                },
                new Message
                {
                    Content = "No man!",
                    By = "Mr No",
                    Date = DateTime.Now.AddHours(1.6)
                },
                new Message
                {
                   Content = "Last message!",
                   By = "Mr Ok",
                   Date = DateTime.Now.AddDays(2)
            }
            };

            await context.Messages.AddRangeAsync(messageslist);
            await context.SaveChangesAsync();
        }
    }
}