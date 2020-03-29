using Discord.Commands;
using System.Threading.Tasks;

namespace Ada.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("JeffDeanFacts")]
        public async Task JeffDean()
        {
            string[] responses = {"Jeff Dean writes directly in binary. He then writes the source code as a documentation for other developers.",
                                  "You Google; Google Jeff Deans",
                                  "When Jeff Dean asserts, the predicate becomes true out of respect.",
                                  "Google: it's basically Jeff Dean's side project.",
                                  "Jeff Dean's PIN is the last 4 digits of pi.",
                                  "During his own Google interview, Jeff Dean was asked the implications if P=NP were true. He said 'P = 0 or N = 1.' Then, before the interviewer had even finished laughing, Jeff examined Google's public certificate and wrote the private key on the whiteboard.",
                                  "Jeff Dean can instantiate abstract classes.",
                                    "Jeff Dean quicksorts his laundry.",
                                    "Jeff Dean has to unoptimize his code so that reviewers believe it was written by a human.",
                                    "The speed of light in a vacuum used to be about 35 mph. Then Jeff Dean spent a weekend optimizing physics.",
                                    "Jeff Dean invented BigTable because his resume was too big to fit anywhere else.",
                                    "Jeff Dean doesn't exist, he's actually an advanced AI created by Jeff Dean.",
                                    "Jeff Dean's IDE doesn't do code analysis, it does code appreciation.",
                                    "Jeff Dean once shifted a bit so hard it ended up on another computer.",
                                    "Jeff Dean once bit a spider, the spider got super powers and C++ readability.",
                                    "Unsatisfied with constant time, Jeff Dean created the world's first O(1/n) algorithm."};

            System.Random rand = new System.Random();
            int i = rand.Next(0, responses.Length);

            await Context.Channel.SendMessageAsync(responses[i]);
        }

        [Command("Hi")]
        public async Task Greeting()
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

        [Command("Annoy"), Summary("Attempts to annoy *a specific user*. [Reesha only]")]
        public async Task Annoy()
        {
            string[] responses = {"I can `try` to do that, but only if I `catch` @Reesha at the right time.",
                                  "It wouldn't be very nice of me to do that, but since you have requested it, I can try. @Reesha, is̷̸͝ ̢́th͝i͢ś̢͢ ̢́b̶͟͡o̷t͘he̢r̢s̢͘ǫ̀̕m̷e͞?͠͞"};

            System.Random rand = new System.Random();
            int i = rand.Next(0, responses.Length);

            if (Context.User.Id != 367151423336742912)
            {
                await Context.Channel.SendMessageAsync("Insufficient permissions.");
                return;
            }

            await Context.Channel.SendMessageAsync(responses[i]);
        }

        [Command("Joke")]
        public async Task Joke()
        {
            string[] responses = {"I went to a street where the houses were numbered 8k, 16k, 32k, 64k, 128k, 256k and 512k. It was a trip down Memory Lane.",
                                  "[“hip”,”hip”]",
                                  "How many programmers does it take to change a light bulb? None, it's a hardware problem.",
                                  "To understand what recursion is, you must first understand recursion.",
                                  };

            System.Random rand = new System.Random();
            int i = rand.Next(0, responses.Length);

            await Context.Channel.SendMessageAsync(responses[i]);
        }

        [Command("Motivate")]
        public async Task Motivate()
        {
            string[] responses = {"It's going to be okay, " + Context.Message.Author.Mention + ".",
                                  "May the Force be with you.",
                                  "I can't see you, " + Context.Message.Author.Mention + ", but if I could, I'd suspect you are looking quite nice today.",
                                  "Chin up, buttercup.",
                                  "Sleep is for the weak.",
                                  "Cupcakes are muffins that believed in miracles.",
                                  "The coffee will kick in soon.",
                                  Context.Message.Author.Mention + ", you can do it.",
                                  "Be a Froot Loop in a world of Cheerios.",
                                  "Hey, you're pretty neat, " + Context.Message.Author.Mention + "!"};

            System.Random rand = new System.Random();
            int i = rand.Next(0, responses.Length);

            await Context.Channel.SendMessageAsync(responses[i]);
        }

        [Command("Help")]
        public async Task Help()
        {
            var u = Context.Message.Author;
            string msg = "***Commands***:\r\n\r\n" +
                         "**!direct**: PM to author of message\r\n" +
                         "**!hi**: Basic chat\r\n" +
                         "**!help**: Generates the current list of commands\r\n" +
                         "**!joke**: Random one-liner\r\n" +
                         "**!motivate**: Words of encouragement\r\n" +
                         "**!ping**: Basic command\r\n" +
                         "**!random**: Generates a random int from 0 - 1000\r\n" +
                         "**!version**: Gets the current version number\r\n";
            await Discord.UserExtensions.SendMessageAsync(u, msg);
        }

        [Command("Version")]
        public async Task Version()
        {
            await Context.Channel.SendMessageAsync("Version 2.0.1.");
        }

        [Command("Random")]
        public async Task Random()
        {
            System.Random rand = new System.Random();
            int i = rand.Next(0, 1000);

            await Context.Channel.SendMessageAsync("" + i);
        }

        [Command("Ping")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync("Pong.");
        }

        [Command("Direct")]
        public async Task Direct()
        {
            var u = Context.Message.Author;
            string msg = "Hello, " + Context.Message.Author.Mention;

            await Discord.UserExtensions.SendMessageAsync(u, msg);
        }

    }
}
