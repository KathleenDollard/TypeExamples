namespace TypeExamples
{
    public struct PersonStructExplicit : IEquatable<PersonStructExplicit>
    {
        public required string GivenName;
        public required string SurName;

        public override bool Equals(object? obj)
        {
            return obj is PersonStructExplicit @struct && Equals(@struct);
        }

        public bool Equals(PersonStructExplicit other)
        {
            return GivenName == other.GivenName &&
                   SurName == other.SurName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GivenName, SurName);
        }

        public static bool operator ==(PersonStructExplicit left, PersonStructExplicit right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PersonStructExplicit left, PersonStructExplicit right)
        {
            return !(left == right);
        }
    }
}
