﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeExamples.Benchmarks;

namespace TypeExamples.Test
{
    public class EqualityTests
    {
        [Fact]
        public void BasicEquality()
        {
            var eqData = new Equality();
            // Change these to be either Assert.True or Assert.False
            //Assert.Fail(eqData.PersonClass1.Equals(eqData.PersonClass2));
            //Assert.Fail(eqData.PersonStruct1.Equals(eqData.PersonStruct2));
            //Assert.Fail(eqData.PersonStructExplicit1.Equals(eqData.PersonStructExplicit2));
            //Assert.Fail(eqData.PersonRecord1.Equals(eqData.PersonRecord2));
            //Assert.Fail(eqData.PersonRecordStruct1.Equals(eqData.PersonRecordStruct2));
        }
    }
}