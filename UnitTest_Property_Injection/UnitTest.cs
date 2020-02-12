using System;

using NUnit.Framework;

namespace UnitTest_Property_Injection
{
    using ECS.Legacy;

    [TestFixture]
    public class UnitTest
    {
        private ECS _uut;
        [SetUp]
        private void SetUp()
        {
            _uut = new ECS(10);
            _uut._heater = new MockHeater();
            _uut._tempSensor = new StubTempSensor();

        }

        [TearDown]
        private void TearDown()
        {

        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(-10)]
        public void Test_Set_Get_Threshold(int n)
        {
            _uut.SetThreshold(n);

            Assert.That(_uut.GetThreshold(),Is.EqualTo(n));
        }





    }
}

//public void Regulate()
//{
//var t = _tempSensor.GetTemp();
//    if (t < _threshold)
//    _heater.TurnOn();
//    else
//_heater.TurnOff();

//}

//public int GetCurTemp()
//{
//return _tempSensor.GetTemp();
//}

//public bool RunSelfTest()
//{
//return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
//}