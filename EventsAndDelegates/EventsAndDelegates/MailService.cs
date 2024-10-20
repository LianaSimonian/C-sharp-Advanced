
using System;

namespace EventsAndDelegates
{
    internal class MailService
    {
        public void OnVideoEncoded(object source,EventArgs e)
        {
            Console.WriteLine("MailService: sending an email .");//eventHandler method
        }
    }
}
