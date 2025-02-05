using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Youtube
{
    internal class Channel
    {
        public string Title { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();

        public void AddVideo(Video video)
        {
            Videos.Add(video);
            //Notify all subscriber
            if (Uploaded is not null)
            {
                Uploaded.Invoke(this, video);
            }
        }

        public Action<Channel,Video> Uploaded;
    }
}
