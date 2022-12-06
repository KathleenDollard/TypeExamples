using BenchmarkDotNet.Attributes;

namespace TypeExamples.Benchmarks
{
    public class EqualityBenchmarks
    {
        private readonly Equality eqData = new();
        [Benchmark]
        public bool CheckEqualsClass() => eqData.PersonClass1.Equals(eqData.PersonClass2);

        [Benchmark]
        public bool CheckEqualsStruct() => eqData.PersonStruct1.Equals(eqData.PersonStruct2);

        [Benchmark]
        public bool CheckEqualsStructExplicit() => eqData.PersonStructExplicit1.Equals(eqData.PersonStructExplicit2);

        [Benchmark]
        public bool CheckEqualsRecord() => eqData.PersonRecord1.Equals(eqData.PersonRecord2);

        [Benchmark]
        public bool CheckEqualsRecordStruct() => eqData.PersonRecordStruct1.Equals(eqData.PersonRecordStruct2);

    }
}
