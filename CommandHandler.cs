﻿using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ada
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;

        }

        private async Task HandleCommandAsync(SocketMessage socketMessage)
        {
            var msg = socketMessage as SocketUserMessage;
            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;

            if(msg.HasCharPrefix('!', ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos);

                if(!result.IsSuccess)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }
            }

        }

    }
}
