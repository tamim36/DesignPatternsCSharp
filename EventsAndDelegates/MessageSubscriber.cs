using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MessageSubscriber
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageSubscriber sending message ..." + args.video.Title);
        }
    }
}
