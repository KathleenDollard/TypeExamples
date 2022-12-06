using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeExamples.Benchmarks;

namespace TypeExamples.Test
{
    public class General
    {
        [Fact]
        public void RealityCheck()
        {
            var eqData = new Equality();
            Assert.False(eqData.PersonClass1.Equals(eqData.PersonClass2));
            Assert.True(eqData.PersonStruct1.Equals(eqData.PersonStruct2));
            Assert.True(eqData.PersonStructExplicit1.Equals(eqData.PersonStructExplicit2));
            Assert.True(eqData.PersonRecord1.Equals(eqData.PersonRecord2));
            Assert.True(eqData.PersonRecordStruct1.Equals(eqData.PersonRecordStruct2));
        }
    }
}
