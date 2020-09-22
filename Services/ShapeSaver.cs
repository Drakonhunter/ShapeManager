using Models;
using System.IO;

namespace Services
{
    public class ShapeSaver : IShapeSaver
    {
        public void SaveShape(Shape shape)
        {
            if (!File.Exists("shapes.csv"))
            {
                using (StreamWriter sw = File.CreateText("shapes.csv"))
                {
                    var line = string.Format("{0},{1},{2},{3},{4}",
                        shape.ShapeName, shape.ShapeColor, shape.ShapeSize, shape.ShapeX, shape.ShapeY);
                    sw.WriteLine(line);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText("shapes.csv"))
                {
                    var line = string.Format("{0},{1},{2},{3},{4}",
                        shape.ShapeName, shape.ShapeColor, shape.ShapeSize, shape.ShapeX, shape.ShapeY);
                    sw.WriteLine(line);
                }
            }
        }
    }

    public interface IShapeSaver
    {
        void SaveShape(Shape shape);
    }
}
