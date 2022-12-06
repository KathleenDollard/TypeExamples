namespace TypeExamples
{
    public class PersonClass 
    {
        public required string GivenName;
        public required string SurName;

        public static PersonClass CreateTest()
            => new()
            {
                GivenName = "John",
                SurName = "Smith"
            };
    }
}
