using System;
using System.Threading;
namespace MoshPrep
{
    public class VideoEncoder
    {
        // 3 steps to achieve event handling
        //1 : define a delegate
        //2: define an event based on that delegate
        //3: raise/ publish the event

        //delegate created
        //event defined
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video =video});
            }
        }
    }
}
