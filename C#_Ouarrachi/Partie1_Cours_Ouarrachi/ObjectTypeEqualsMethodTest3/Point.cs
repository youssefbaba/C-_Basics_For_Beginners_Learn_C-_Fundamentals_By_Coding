using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest3
{
    internal class Point
    {
        // fields
        public int x;
        public int y;

        // constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
            // object obj = r.a = (0,0)
            // this = this.a = (0,0)
            // object obj = r.b = (150,200)
            // this = this.b = (100,200)
            //Console.WriteLine(this.GetType()); Point
            //Console.WriteLine(obj.GetType()); Point
            // Performs an equality check on two points (integer pairs).
            if (obj == null || this.GetType() != obj.GetType()) 
            {
                return false;
            } 
            Point p = (Point)obj;
            return (this.x == p.x) && (this.y == p.y);
        }
        public override int GetHashCode()
        {
            return Tuple.Create(x, y).GetHashCode();
        }
    }
}
