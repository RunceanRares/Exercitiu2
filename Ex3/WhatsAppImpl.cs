using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class WhatsAppImpl : IMessagingService
    {
        public void SendFile()
        {
            Console.WriteLine("Send file from WhatsApp");
        }

        public void SendMessage()
        {
            Console.WriteLine("Send message from WhatsApp");
        }

        public void VideoCall()
        {
            Console.WriteLine("Video call from WhatsApp");
        }

        public void VoiceCall()
        {
            Console.WriteLine("Voice call from WhatsApp");
        }
    }
}
