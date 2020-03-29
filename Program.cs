using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Ada
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Program().StartAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            Console.WriteLine("Bot is starting up. (2018, by Reesha Rajen) v. 2.1");
            Console.WriteLine("Success!");

           _client = new DiscordSocketClient();

            //new CommandHandler(_client); //this was creating an extra bot.

            await _client.LoginAsync(TokenType.Bot, "NDE1MTA1Njc4OTc0Mzg2MTc3.DXPqWQ.XzhbA8eAK4pg1c5-Yz0rhcDwenc"); // nice token :p

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}
