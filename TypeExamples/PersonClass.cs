namespace TypeExamples
{
    internal class PersonClass : IEquatable<PersonClass?>
    {
        public required string GivenName;
        public required string SurName;

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonClass);
        }

        public bool Equals(PersonClass? other)
        {
            return other is not null &&
                   GivenName == other.GivenName &&
                   SurName == other.SurName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GivenName, SurName);
        }

        public static bool operator ==(PersonClass? left, PersonClass? right)
        {
            return EqualityComparer<PersonClass>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonClass? left, PersonClass? right)
        {
            return !(left == right);
        }
    }
}
