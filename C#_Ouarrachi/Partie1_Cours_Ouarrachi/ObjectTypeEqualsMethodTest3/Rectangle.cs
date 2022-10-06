using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest3
{
    internal class Rectangle
    {
        // Fields
        public Point a, b;

        // Constructor
        public Rectangle(int upLeftX , int upLeftY , int downRightX , int downRightY)
        {
            this.a = new Point(upLeftX , upLeftY);
            this.b = new Point(downRightX, downRightY);
        }
        public override bool Equals(object obj)
        {
            // object obj = r3 of type Rectangle = (0,0,150,200)
            // this = r2 of type Rectangle = (0,0,100,200)
            // Perform an equality check on two rectangles (Point object pairs).
            if (obj == null || this.GetType() != obj.GetType() )
            {
                return false;
            }
            Rectangle r = (Rectangle)obj;
            return this.a.Equals(r.a) && this.b.Equals(r.b);
            
        }
        public override int GetHashCode()
        {
            return Tuple.Create(a, b).GetHashCode();
        }

        public override String ToString()
        {
            return $"Rectangle({a.x},{a.y},{b.x},{b.y})"; 
        }
    }
}
