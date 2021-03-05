using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // To publish an event follow 3 steps
        // 1- Define a delegate (agreement between publisher and subscriber)
        // 2- Define an event based on that delegate
        // 3- Raise the event by convention create method protected virtual void

        // Here source is the publisher class and args is additional data to send
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"{video.Title} Encoding video ...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = video});
        }
    }
}
