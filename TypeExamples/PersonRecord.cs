namespace TypeExamples
{
    public record PersonRecord
    {
        public required string GivenName;
        public required string SurName;

        public static PersonRecord CreateTest()
            => new()
            {
                GivenName = "John",
                SurName = "Smith"
            };
    }
}
