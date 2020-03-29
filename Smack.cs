using System;
using Discord.Commands;
using System.Threading.Tasks;

namespace Ada.Modules
{
    public class Smack : ModuleBase<SocketCommandContext>
    {

        [Command("smack"), Alias("slap"), Summary("Smacks the specified person")]
        public async Task Smacked(Discord.WebSocket.SocketUser user)
        {

            string[] _smacks = {
            "https://media.giphy.com/media/HgChXkcHSAgAE/giphy.gif",
            "https://media0.giphy.com/media/3o85xKRIokv92FRo52/giphy.gif",
            "https://media3.giphy.com/media/l0Iy4KUJ0Q4prROOQ/giphy.gif",
            "https://media3.giphy.com/media/Hz3YLyGYc15Oo/giphy.gif",
            "https://media3.giphy.com/media/twVsJCwnQhIac/giphy.gif"
            };

            System.Random rand = new System.Random();
            int i = rand.Next(0, _smacks.Length);

            await ReplyAsync(_smacks[i]);

            /*
            [Command("roll"), Summary("rolls a dice of arbitrary size. (example: \'!roll 33\' rolls a 33-sided die)")]
        public async Task Say(string argSize)
        {
            Random rand = new Random();
            uint num = 0;
            num = (uint)rand.Next(1, (int)Convert.ToUInt32(argSize, 10));
            await Context.Channel.SendMessageAsync("you rolled a " + num);
        }*/
        }
    
    }
}
