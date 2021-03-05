using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MailSubscriber
    {
        // Event Handler that as same as delegate signature
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailSubscriber: sending an email ... " + args.video.Title);
        }
    }
}
