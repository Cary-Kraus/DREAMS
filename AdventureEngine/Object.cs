using AdventureEngine;

namespace DREAMS
{
    public class Object
    {
        public Sprite sprite;
        public double x;
        public double y;
        protected float speed_x, speed_y;

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
