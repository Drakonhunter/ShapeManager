using System;

namespace Models
{
    public class Shape
    {
        private string shapeName;
        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

        private string shapeColor;
        public string ShapeColor
        {
            get { return shapeColor; }
            set { shapeColor = value; }
        }

        private double shapeSize;
        public double ShapeSize
        {
            get { return shapeSize; }
            set
            {
                //minimum shapeSize = 1.0
                if (value < 1)
                    value = 1.0;
                shapeSize = value;
            }
        }

        public int ShapeX { get; set; }
        public int ShapeY { get; set; }

        public Shape(string sn)
        {
            ShapeName = sn;
            ShapeColor = "red";
            ShapeSize = 0;
            ShapeX = 0;
            ShapeY = 0;
        }
        public Shape(string sn, string co, double sz, int x, int y)
        {
            ShapeName = sn;
            ShapeColor = co;
            ShapeSize = sz;
            ShapeX = x;
            ShapeY = y;
        }

        public void showInfo()
        {
            Console.WriteLine("shape: ");
            Console.WriteLine("  name: " + ShapeName);
            Console.WriteLine("  color:" + ShapeColor);
            Console.WriteLine("  size: " + ShapeSize);
        }

        public override string ToString()
        {
            return ShapeName;
        }


    }
}
