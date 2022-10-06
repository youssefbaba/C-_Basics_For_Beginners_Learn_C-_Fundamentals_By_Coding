using System;

namespace ObjectTypeEqualsMethodTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point2D = new Point(5,5);
            Point3D point3Da = new Point3D(5,5,2);
            Point3D point3Db = new Point3D(5,5,2);
            Point3D point3Dc = new Point3D(1,2,3);




            Console.WriteLine($"{point2D} = {point3Da} : {point2D.Equals(point3Da)}");
            // {point2D} = point2D.ToString() = Point(5,5)
            // {point3Da}  = point3Da.ToString() = Point(5,5,2)
            // {point2D.Equals(point3Da)} = (5,5).Equals((5,5,2)) =  False
            // Point(5,5) = Point(5,5,2) : False




            Console.WriteLine($"{point2D} = {point3Db} : {point2D.Equals(point3Db)}");
            // {point2D} = point2D.ToString() = Point(5,5)
            // {point3Db}  = point3Db.ToString() = Point(5,5,2)
            // {point2D.Equals(point3Db)} = (5,5).Equals((5,5,2)) = False
            // Point(5,5) = Point(5,5,2) : False




            Console.WriteLine($"{point3Da} = {point3Db} : {point3Da.Equals(point3Db)}");
            // {point3Da} = point3Da.ToString() = Point(5,5,2)
            // {point3Db} = point3Db.ToString() = Point(5,5,2)
            // {point3Da.Equals(point3Db)} = (5,5,2).Equals(5,5,2) = True
            // Point(5,5,2) = Point(5,5,2) : True




            Console.WriteLine($"{point3Da} = {point3Dc} : {point3Da.Equals(point3Dc)}");
            // {point3Da} = point3Da.ToString() = Point(5,5,2)
            // {point3Dc} = point3Dc.ToString() = Point(1,2,3)
            // {point3Da.Equals(point3Dc)} = (5,5,2)Equals((1,2,3)) =  False
            // Point(5,5,2) = Point(1,2,3) : False


            /*
                Point(5,5) = Point(5,5,2) : False
                Point(5,5) = Point(5,5,2) : False
                Point(5,5,2) = Point(5,5,2) : True
                Point(5,5,2) = Point(1,2,3) : False
             */
        }
    }
}


