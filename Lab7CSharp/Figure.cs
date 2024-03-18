using System.Drawing;

namespace Lab7CSharp
{
    abstract class Shape
    {
        protected int x, y; 
        protected int width, height; 
        protected Color color;

        public Shape(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public abstract void Draw(Graphics g);

        public virtual void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }

    class Pentagon : Shape
    {
        public Pentagon(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
        }

        public override void Draw(Graphics g)
        {
            Point[] points =
            {
                new Point(x + width / 2, y),
                new Point(x + width, y + height / 3),
                new Point(x + width * 2 / 3, y + height),
                new Point(x + width / 3, y + height),
                new Point(x, y + height / 3)
            };
            g.FillPolygon(new SolidBrush(color), points);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), x, y, width, height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
        }

        public override void Draw(Graphics g)
        {
            Point[] points =
            {
                new Point(x + width / 2, y),
                new Point(x + width, y + height),
                new Point(x, y + height)
            };
            g.FillPolygon(new SolidBrush(color), points);
        }
    }

    class Rhombus : Shape
    {
        public Rhombus(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
        }

        public override void Draw(Graphics g)
        {
            Point[] points =
            {
                new Point(x + width / 2, y),
                new Point(x + width, y + height / 2),
                new Point(x + width / 2, y + height),
                new Point(x, y + height / 2)
            };
            g.FillPolygon(new SolidBrush(color), points);
        }
    }
}
