using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ.Core
{
    public static class MessageQueue
    {
        public static List<string> Messages = new List<string>() { };

        public static void Create(string message)
        {
            Messages.Add(message);
        }

        internal static bool Exists(string v)
        {
            return Messages.Contains(v);
        }

        public static bool Delete(string message)
        {
            return Messages.Remove(message);
        }
        public static List<string> GetMessages()
        {
            return Messages;
        }
    }
}
