﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris.Irc
{
    public sealed class IrcLineEventArgs : EventArgs
    {
        public string Line { get; set; }
    }

    public sealed class IrcMessageEventArgs : EventArgs
    {
        public string Message { get; set; }

        public string Recipient { get; set; }

        public string Sender { get; set; }
    }

    public sealed class IrcNumericalMessageEventArgs : EventArgs
    {
        public string? Arguments { get; set; }

        public string? Message { get; set; }

        public IrcNumericalMessageTypes MessageType { get; set; }

        public string Recipient { get; set; }

        public string Sender { get; set; }
    }
}