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


        }

        [TearDown]
        private void TearDown()
        {

        }



    }
}
