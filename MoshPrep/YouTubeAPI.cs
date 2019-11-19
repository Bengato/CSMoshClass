using System;
using System.Collections.Generic;

namespace MoshPrep
{
    public class YouTubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //access YouTube web service
                //Read data
                //Create a list of video objects
            }
            catch(Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from YouTube ",ex);
            }
            return new List<Video>();
        }
    }
}
