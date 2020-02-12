using System;
using ECS.Legacy;
using NUnit.Framework;

namespace UnitTest_Constructor_Injection
{

    public class ECS_Constructor_Injection_Test
    {
        private ECS.Legacy.ECS uut_;
        [SetUp]
        public void SetUp()
        {
            uut_ = new ECS.Legacy.ECS(20, new MockHeater(), new StubTempSensor());
        }

        
    }
}
