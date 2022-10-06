using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest
{
    internal class Point
    {
        // Fieldes
        public int x;
        public int y;


        // Constructure
        public Point():this(0,0)
        {}

        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        // overriding of equals methods for test value equality

        public override bool Equals(object obj)
        {
            // obj = point3Db = (5,5,2)
            // this = point3Da = (5,5,2)
            //Console.WriteLine(this.GetType()); 
            //Console.WriteLine(obj.GetType()); 
            //Check for null and compare run-time types.
            if ( (obj == null) || (!this.GetType().Equals(obj.GetType())) )
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                //Console.WriteLine(this.x);
                //Console.WriteLine(this.y);
                return (this.x == p.x) && (this.y == p.y);
            } 
        }
        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }
        public override string ToString()
        {
            return $"Point({x},{y})";
        }
    }
}
