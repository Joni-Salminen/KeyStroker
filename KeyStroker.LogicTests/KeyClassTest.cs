using KeyStroker.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KeyStroker.LogicTests
{
    [TestClass]
    public class KeyClassTest
    {
        [TestMethod]
        public void TimeAndButtonProperlySet()
        {
            Key key = new Key('a', 100);

            char expectedButton = 'a';
            int expectedTime = 100;

            Assert.AreEqual(expectedTime, key.Time);
            Assert.AreEqual(expectedButton, key.Button);
        }

        [TestMethod]
        public void TimerValueChanged()
        {
            Key key = new Key('a', 100);
            key.Time = 50;

            int expectedTime = 50;

            Assert.AreEqual(expectedTime, key.Time);
        }

        [TestMethod]
        public void CanTimerRun()
        {
            Key key = new Key('a', 100);
            key.StartTimer();

            bool expectedOutcome = true;

            Assert.AreEqual(expectedOutcome, key.TimerRunning());
        }

        [TestMethod]
        public void CanOneTimerOfManyRun()
        {
            Key key1 = new Key('a', 100);
            Key key2 = new Key('b', 200);
            key1.StartTimer();
            
            bool key1Outcome = true;
            bool key2Outcome = false;

            Assert.AreEqual(key1Outcome, key1.TimerRunning());
            Assert.AreEqual(key2Outcome, key2.TimerRunning());
        }

        [TestMethod]
        public void CanManyTimersRun()
        {
            Key key1 = new Key('a', 100);
            Key key2 = new Key('b', 200);
            key1.StartTimer();
            key2.StartTimer();

            bool key1Outcome = true;
            bool key2Outcome = true;

            Assert.AreEqual(key1Outcome, key1.TimerRunning());
            Assert.AreEqual(key2Outcome, key2.TimerRunning());
        }

        [TestMethod]
        public void CanTimerBeStopped()
        {
            Key key = new Key('a', 100);
            key.StartTimer();
            key.StopTimer();

            bool keyOutcome = false;

            Assert.AreEqual(keyOutcome, key.TimerRunning());
        }

    }
}
