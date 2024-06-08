using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Animation : Sprite
    {
        Image[] images;
        int cur_frame;
        public bool running;

        public Animation(List<string> frames)
        {
            x = 0;
            y = 0;
            cur_frame = 0;
            images = new Image[frames.Count];
            for (int i = 0; i < images.Length; i++)
                images[i] = new Sprite(frames[i]).img;
            img = images[0];
            running = true;
        }
        public override void Update()
        {
            //при каждом вызове этого метод текущий спрайт должен меняться на след.
            if (running)
            {
                img = images[cur_frame++];
                if (cur_frame == images.Length)
                    cur_frame = 0;
            }
        }
    }
}
