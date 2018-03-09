using MSQue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSQue.SenderApp
{
    class Program
    {
        static MessageQueue messageQueue;

        static void Main(string[] args)
        {
            var path = @".\Private$\TESTING";
            try
            {
                if (MessageQueue.Exists(path))
                {
                    messageQueue = new MessageQueue(path);
                    messageQueue.Label = "This is a test queue.";
                }
                else
                {
                    MessageQueue.Create(path);
                    messageQueue = new MessageQueue(path);
                    messageQueue.Label = "This is a test queue.";
                }
            }
            catch
            {
                throw;
            }
            messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(UserMessage) });

            input();
        }

        static void input()
        {
            Console.Write("Add message: " + System.Environment.NewLine);
            var name = Console.ReadLine();
            var msg = new UserMessage()
            {
                MessageText = name,
                MessageTime = DateTime.Now
            };
            messageQueue.Send(msg, "TESTING");

            input();
        }
    }
}
