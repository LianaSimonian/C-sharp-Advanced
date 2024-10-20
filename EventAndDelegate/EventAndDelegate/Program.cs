
namespace EventAndDelegate
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


