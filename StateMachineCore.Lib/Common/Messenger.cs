using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachineCore.Lib
{
    public delegate void MessageReceivedHandler(string message);

    public static class Messenger
    {
        public static MessageReceivedHandler OnMessageReceived;

        public static void Send(string message)
        {
            Messenger.OnMessageReceived?.Invoke(message);
        }
    }
}
