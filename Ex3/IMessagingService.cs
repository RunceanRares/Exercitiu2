using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public interface IMessagingService
    {
        void SendMessage();
        void SendFile();
        void VoiceCall();
        void VideoCall();

    }
}
