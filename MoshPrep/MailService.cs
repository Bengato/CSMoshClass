using System;
namespace MoshPrep
{
    public class MailService {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending an email about video:"+args.Video.Title);
        }
    }
}
