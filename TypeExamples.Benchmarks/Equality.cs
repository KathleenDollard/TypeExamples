using BenchmarkDotNet.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TypeExamples.Benchmarks
{
    public class Equality
    {
        public PersonStruct pStruct1 = new PersonStruct
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonStruct pStruct2 = new PersonStruct
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonStructExplicit pStructExplicit1 = new PersonStructExplicit
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonStructExplicit pStructExplicit2 = new PersonStructExplicit
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonClass pClass1 = new PersonClass
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonClass pClass2 = new PersonClass
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonRecordStruct pRecordStruct1 = new PersonRecordStruct
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonRecordStruct pRecordStruct2 = new PersonRecordStruct
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonRecord pRecord1 = new PersonRecord
        {
            GivenName = "John",
            SurName = "Smith"
        };
        public PersonRecord pRecord2 = new PersonRecord
        {
            GivenName = "John",
            SurName = "Smith"
        };

        [Benchmark]
        public bool CheckEqualsClass() => pClass1.Equals(pClass2);

        [Benchmark]
        public bool CheckEqualsStruct() => pStruct1.Equals(pStruct2);

        [Benchmark]
        public bool CheckEqualsStructExplicit() => pStructExplicit1.Equals(pStructExplicit2);

        [Benchmark]
        public bool CheckEqualsRecord() => pRecord1.Equals(pRecord2);

        [Benchmark]
        public bool CheckEqualsRecordStruct() => pRecordStruct1.Equals(pRecordStruct2);

    }
}
