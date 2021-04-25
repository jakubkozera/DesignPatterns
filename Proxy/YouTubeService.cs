using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class YouTubeService : IYouTubeService
    {
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Youtube serivce downloading video: {videoId}");


            return new byte[videoId];
        }
    }
}
