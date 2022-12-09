using TypeExamples;
using TypeExamples.Benchmarks;

namespace TypeExamples.Test
{
    public class PassingSemantics
    {


        [Fact]
        public void PassSemanticsClass()
        {
            var personClass = PersonClass.CreateTest();
            MakeChangeClass(personClass);
            // Uncomment the following and Assert.Equal or Assert.NotEqual
            //Assert.Fail("John", personClass.GivenName);

            static void MakeChangeClass(PersonClass person) => person.GivenName = "Joe";
        }

        [Fact]
        public void PassSemanticsStruct()
        {
            var personStruct = PersonStruct.CreateTest();
            MakeChangeStruct(personStruct);
            // Uncomment the following and Assert.Equal or Assert.NotEqual
            //Assert.Fail("John", personStruct.GivenName);

            static void MakeChangeStruct(PersonStruct person) => person.GivenName = "Joe";
        }

        [Fact]
        public void PassSemanticsRecord()
        {
            var personRecord = PersonRecord.CreateTest();
            MakeChangeRecord(personRecord);
            // Uncomment the following and Assert.Equal or Assert.NotEqual
            //Assert.Fail("John", personRecord.GivenName);

            static void MakeChangeRecord(PersonRecord person) => person.GivenName = "Joe";
        }


        [Fact]
        public void PassSemanticsRecordStruct()
        {
            var personRecordStruct = PersonRecordStruct.CreateTest();
            MakeChangeRecordStruct(personRecordStruct);
            // Uncomment the following and Assert.Equal or Assert.NotEqual
            //Assert.Fail("John", personRecordStruct.GivenName);

            static void MakeChangeRecordStruct(PersonRecordStruct person) => person.GivenName = "Joe";
        }

    }
}