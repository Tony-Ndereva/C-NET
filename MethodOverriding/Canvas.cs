using System.Collections.Generic;

namespace C_NET.MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {

                shape.Draw();
            }
        }



    }
}
