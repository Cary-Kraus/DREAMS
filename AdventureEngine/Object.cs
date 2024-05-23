using AdventureEngine;

namespace DREAMS
{
    public class Object
    {
        public Sprite sprite;
        public int x;
        public int y;
        public int speed_x;
        public int speed_y;

        public Object(Sprite s)
        {
            sprite = s;
        }
        public Object(Sprite s, Line line)
        {
            sprite = s;
        }
        public virtual void Update()
        {
            //x += speed_x;
            //y += speed_y;
            //sprite.x = x;
            //sprite.y = y;
        }
    }
}
