using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Title 1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;//subscription
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;//subscription

            videoEncoder.Encode(video);
        }
    }
}
