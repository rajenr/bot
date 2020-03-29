using Discord.Commands;
using System.Threading.Tasks;

namespace Ada.Modules
{
    public class Greeting : ModuleBase<SocketCommandContext>
    {
        [Command("Hi")]
        public async Task Hi()
        {
            string[] responses = {"Hi " + Context.Message.Author.Mention + ", I'm Ada.",
                                  "Hello " + Context.Message.Author.Mention,
                                  "Yo, " + Context.Message.Author.Mention,
                                  "Hi, " + Context.Message.Author.Mention + "! Ada here.",
                                  "How can I help you, " + Context.Message.Author.Mention + "?",
                                  "Hi, " + Context.Message.Author.Mention + "!",
                                  "Hey " + Context.Message.Author.Mention + ", we meet again."};

            System.Random rand = new System.Random();
            int i = rand.Next(0, responses.Length);

            await Context.Channel.SendMessageAsync(responses[i]);
        }
    }
}
