﻿using System;

namespace MoshPrep
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message,Exception innerException)
            :base(message,innerException)
        {

        }
    }
}
