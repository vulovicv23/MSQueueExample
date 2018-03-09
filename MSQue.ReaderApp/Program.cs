using MSQue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSQue.ReaderApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var path = @".\Private$\TESTING";

            using (MessageQueue messageQueue = new MessageQueue(path))
            {
                while (true)
                {
                    var message = messageQueue.Receive();
                    message.Formatter = new XmlMessageFormatter(new Type[] { typeof(UserMessage) });
                    var userMsg = (UserMessage)message.Body;
                    Console.WriteLine("At " + userMsg.MessageTime + " user sent: " + userMsg.MessageText);
                }
            }
        }
    }
}
