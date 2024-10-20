
using System;

namespace EventAndDelegate
{
    public class MessageService
    {
        //eventHandler
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: sending text message " + args.Video.Title);
        }
    }
}
