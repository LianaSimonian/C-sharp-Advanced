
using System;

namespace EventAndDelegate
{
    internal class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an email ." + e.Video.Title);//eventHandler method
        }
    }
}

