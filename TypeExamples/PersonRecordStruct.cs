namespace TypeExamples
{
    public record struct PersonRecordStruct
    {
        public string GivenName;
        public string SurName;

        public static PersonRecordStruct CreateTest()
            => new()
            {
                GivenName = DateTime.Now.Month.ToString(),
                SurName = DateTime.Now.Year.ToString()
            };
    }
}
