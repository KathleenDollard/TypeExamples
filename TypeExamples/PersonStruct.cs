namespace TypeExamples
{
    public struct PersonStruct
    {
        public required string GivenName;
        public required string SurName;

        public static PersonStruct CreateTest()
            => new()
            {
                GivenName = DateTime.Now.Month.ToString(),
                SurName = DateTime.Now.Year.ToString()
            };
    }
}
