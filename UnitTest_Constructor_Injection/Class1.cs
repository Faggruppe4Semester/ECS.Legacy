using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTest_Constructor_Injection
{
    using ECS.Legacy;
    [TestFixture]
    public class ECS_Constructor_Injection_Test
    {
        [TestCase(5, "Fake Heater is off\r\n")]
        [TestCase(15, "Fake Heater is on\r\n")]
        public void Regulate_Test_Heater_TurnOn_Called(int thr, string expected)
        {
            ECS uut_ = new ECS(thr, new MockHeater(), new StubTempSensor());
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected_ = expected;

                uut_.Regulate();

                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [TestCase(15)]
        public void SetThreshHold_GetInsertedThreshold(int thr)
        {
            ECS uut_ = new ECS(10, new MockHeater(), new StubTempSensor());

            uut_.SetThreshold(thr);
            Assert.That(uut_.GetThreshold(), Is.EqualTo(thr));
        }

        [TestCase(10)]
        public void GetCurTemp_ReturnsConstantStubValue(int expected)
        {
            ECS uut_ = new ECS(10, new MockHeater(), new StubTempSensor());
            Assert.That(uut_.GetCurTemp(), Is.EqualTo(expected));
        }

        [Test]
        public void RunSelfTest_ReturnsTrueForStubs()
        {
            ECS uut_ = new ECS(10, new MockHeater(), new StubTempSensor());
            Assert.That(uut_.RunSelfTest(), Is.EqualTo(true));
        }
    }
}
