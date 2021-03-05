using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Movie" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailSubscriber = new MailSubscriber(); // Subscriber
            var messageSubscriber = new MessageSubscriber();

            videoEncoder.VideoEncoded += mailSubscriber.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageSubscriber.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
