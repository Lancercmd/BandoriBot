using BandoriBot.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandoriBot.Handler
{
    class WhitelistHandler : IMessageHandler
    {
        public bool IgnoreCommandHandled => true;

        public bool OnMessage(string message, Source Sender, bool isAdmin, Action<string> callback)
        {
            return !Configuration.GetConfig<Whitelist>().hash.Contains(Sender.FromGroup) && !isAdmin;
        }
    }
}
