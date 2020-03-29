using Discord.Commands;
using System.Threading.Tasks;

namespace Ada.Modules
{
    public class Act : ModuleBase<SocketCommandContext>
    {
        [Command("TableFlip")]
        public async Task TableFlip()
        {
            await Context.Channel.SendMessageAsync("(╯°□°）╯︵ ┻━┻");
        }

        [Command("Unflip")]
        public async Task Unflip()
        {
            await Context.Channel.SendMessageAsync("┬─┬ ノ( ゜-゜ノ)");
        }

        [Command("Shrug")]
        public async Task Shrug()
        {
            await Context.Channel.SendMessageAsync("¯\\_(ツ)_/¯");
        }
    }


}
