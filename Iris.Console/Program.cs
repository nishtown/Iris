using Iris.Bouncer;
using Iris.Irc;
using Iris.Irc.ServerMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Iris.ConsoleTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IrcConnection ircConnection = new IrcConnection(new ServerDetails() { Port = 6667, Address = "irc.esper.net", Name = "Esper.net" });

            Client client = new Client(ircConnection, new ClientConfig() { Nickname = "Nish|Iris", Password = "", UserMode = 0, Username = "Nishtown" });
            client.Message += (sender, line) => Console.WriteLine(line);
            client.PrivateMessage += client_PrivateMessage;
            client.Connected += client_Connected;

            Thread clientThread = new Thread((ParameterizedThreadStart)((object delay) => client.Run((Action)delay)));
            clientThread.Name = "Client - Esper.net";
            clientThread.IsBackground = true;
            clientThread.Start((Action)(() => Thread.Sleep(100))); //Needs the delay action passed in because Portable Class Libraries don't support Threads ...

            Console.WriteLine("Press enter to stop threads.");
            Console.ReadLine();

            client.Stop();

            Console.WriteLine("Threads should be stopping.");
            Console.ReadLine();
        }

        static void client_Connected(Client sender)
        {
            Console.WriteLine("Connected!");
        }

        static void client_PrivateMessage(Client sender, PrivateMessage privateMessage)
        {
            string user = privateMessage.User.Split('!')[0];
            string rcpt = privateMessage.Recipient;
            if (privateMessage.Recipient == sender.Config.Nickname)
            {
                rcpt = user;
            }

            if (privateMessage.Message.StartsWith("."))
            {
                
                string cmd = privateMessage.Message;
                string msg = "";
                
                if (privateMessage.Message.Contains(' '))
                {
                    cmd = privateMessage.Message.Substring(0, privateMessage.Message.IndexOf(' '));
                    msg = privateMessage.Message.Substring(cmd.Length + 1, privateMessage.Message.Length - cmd.Length - 1);
                }

                switch (cmd.ToUpper())
                {
                    case ".JOIN":
                        if (msg.Contains(' '))
                        {
                            msg = msg.Split(' ')[0];
                        }
                        sender.Join(msg);
                        break;
                    case ".PART":
                        if (msg.Contains(' '))
                        {
                            sender.Leave(msg.Split(' ')[0]);
                        }
                        else
                        {
                            if (rcpt.StartsWith("#"))
                            {
                                sender.Leave(rcpt);
                            }
                        }
                        break;
                    case ".WAVE":
                        sender.Send(rcpt, "o/");
                        break;

                    case ".SEEN":
                        
                        break;
                }
            }

        }

        
    }
}