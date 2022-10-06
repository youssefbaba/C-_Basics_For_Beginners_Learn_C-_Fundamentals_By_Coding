namespace ValueTypeAndReferenceType
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person other = (Person)obj;
                return (Name == other.Name);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
