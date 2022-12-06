
namespace TypeExamples.Benchmarks
{
    public class Equality
    {
        public  PersonStruct PersonStruct1 = PersonStruct.CreateTest();
        public  PersonStruct PersonStruct2 = PersonStruct.CreateTest();
        public  PersonStructExplicit PersonStructExplicit1 = PersonStructExplicit.CreateTest();
        public  PersonStructExplicit PersonStructExplicit2 = PersonStructExplicit.CreateTest();
        public  PersonClass PersonClass1 = PersonClass.CreateTest();
        public  PersonClass PersonClass2 = PersonClass.CreateTest();
        public  PersonRecordStruct PersonRecordStruct1 = PersonRecordStruct.CreateTest();
        public  PersonRecordStruct PersonRecordStruct2 = PersonRecordStruct.CreateTest();
        public  PersonRecord PersonRecord1 = PersonRecord.CreateTest();
        public  PersonRecord PersonRecord2 = PersonRecord.CreateTest();

        public  bool CheckEqualsClass() => PersonClass1.Equals(PersonClass2);

        public  bool CheckEqualsStruct() => PersonStruct1.Equals(PersonStruct2);

        public  bool CheckEqualsStructExplicit() => PersonStructExplicit1.Equals(PersonStructExplicit2);

        public  bool CheckEqualsRecord() => PersonRecord1.Equals(PersonRecord2);

        public  bool CheckEqualsRecordStruct() => PersonRecordStruct1.Equals(PersonRecordStruct2);

    }
}
