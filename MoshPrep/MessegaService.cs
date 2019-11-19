using System;
namespace MoshPrep
{
    public class MessegaService {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine("MessageService : sending a text message about video:" + args.Video.Title);
        }
    }
}
