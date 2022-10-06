namespace ValueTypeAndReferenceType
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }


        //public override bool Equals(object obj)
        //{
        //    return obj is Point other && this == other;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(X, Y);
        //}
    }
}
