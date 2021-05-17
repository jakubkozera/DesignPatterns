using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeService youTubeService = new YouTubeService();

            

            ProxyYouTubeService proxyYouTubeService= new ProxyYouTubeService(youTubeService);
            proxyYouTubeService.GetVideo(10);
            proxyYouTubeService.GetVideo(10);
        }
    }
}
