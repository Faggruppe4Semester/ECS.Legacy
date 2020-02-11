using System;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }

    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    internal class StubTempSensor : ITempSensor
    {
        private int _gen = 10;
        
        public int Gen { get; set; }

        public int GetTemp()
        {
            return _gen;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}