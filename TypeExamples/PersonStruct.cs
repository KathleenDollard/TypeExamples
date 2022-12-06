namespace TypeExamples
{
    internal class PersonStruct : IEquatable<PersonStruct?>
    {
        public required string GivenName;
        public required string SurName;

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonStruct);
        }

        public bool Equals(PersonStruct? other)
        {
            return other is not null &&
                   GivenName == other.GivenName &&
                   SurName == other.SurName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GivenName, SurName);
        }

        public static bool operator ==(PersonStruct? left, PersonStruct? right)
        {
            return EqualityComparer<PersonStruct>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonStruct? left, PersonStruct? right)
        {
            return !(left == right);
        }
    }
}
