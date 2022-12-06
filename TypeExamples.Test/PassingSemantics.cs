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
            Assert.Equal("John", personClass.GivenName);

            static void MakeChangeClass(PersonClass person) => person.GivenName = "Joe";
        }

        [Fact]
        public void PassSemanticsStruct()
        {
            var personStruct = PersonStruct.CreateTest();
            MakeChangeStruct(personStruct);
            Assert.Equal("John", personStruct.GivenName);

            static void MakeChangeStruct(PersonStruct person) => person.GivenName = "Joe";
        }

        [Fact]
        public void PassSemanticsRecord()
        {
            var personRecord = PersonRecord.CreateTest();
            MakeChangeRecord(personRecord);
            Assert.Equal("John", personRecord.GivenName);

            static void MakeChangeRecord(PersonRecord person) => person.GivenName = "Joe";
        }


        [Fact]
        public void PassSemanticsRecordStruct()
        {
            var personRecordStruct = PersonRecordStruct.CreateTest();
            MakeChangeRecordStruct(personRecordStruct);
            Assert.Equal("John", personRecordStruct.GivenName);

            static void MakeChangeRecordStruct(PersonRecordStruct person) => person.GivenName = "Joe";
        }

    }
}