using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookMessenger facebookMessenger = new FacebookMessenger(new FacebookMessengerImpl());
            facebookMessenger.SendFile();
            facebookMessenger.SendMessage();

            Console.WriteLine();

            Skype skype = new Skype(new SkypeImpl());
            skype.SendFile();
            skype.SendMessage();

            Console.WriteLine();

            WhatsApp whatsApp = new WhatsApp(new WhatsAppImpl());
            whatsApp.SendFile();
            whatsApp.SendMessage();
        }
    }
}
