using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KeyStroker.Logic;

namespace KeyStroker.LogicTests
{
    [TestClass]
    public class KeyControllerTests
    {
        [TestMethod]
        public void KeyProperlyRegistered()
        {
            var controller = new KeyController();
            controller.registerNewKey('a', 100);
            controller.registerNewKey('b', 100);

            char expectedChar1 = 'a';
            char expectedChar2 = 'b';
            double expectedTime1 = 100;
            double expectedTime2 = 100;

            Assert.AreEqual(expectedChar1, controller.keyList[0].Button);
            Assert.AreEqual(expectedTime1, controller.keyList[0].Time);
            Assert.AreEqual(expectedChar2, controller.keyList[1].Button);
            Assert.AreEqual(expectedTime2, controller.keyList[1].Time);
        }

        [TestMethod]
        public void AllTimersStart()
        {
            var controller = new KeyController();

            for(int i = 0; i < 10; i++)
            {
                controller.registerNewKey('a', i * 10);
            }

            controller.startAllTimers();

            foreach(ProgrammableButton key in controller.keyList)
            {
                Assert.AreEqual(true, key.TimerRunning());
            }
        }

        [TestMethod]
        public void AllTimersStop()
        {
            var controller = new KeyController();

            for (int i = 5; i < 10; i++)
            {
                controller.registerNewKey('a', i * 10);
            }

            controller.startAllTimers();
            controller.stopAllTimers();

            foreach (ProgrammableButton key in controller.keyList)
            {
                Assert.AreEqual(false, key.TimerRunning());
            }
        }
    }
}
