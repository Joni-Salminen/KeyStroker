using KeyStroker.FileSaving;
using KeyStroker.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KeyStroker.FileSavingTests
{
    [TestClass]
    public class FileSavingTests
    {
        [TestMethod]
        public void CanChangeSavePath()
        {
            FileWriter.SavePath = "test.txt";

            string expectedSavePath = "test.txt";

            Assert.AreEqual(expectedSavePath, FileWriter.SavePath);
        }

        [TestMethod]
        public async Task CanSaveAndReadFile()
        {
            // Create new keyList and assign values to it and save it
            List<Key> keyList = new List<Key>();
            keyList.Add(new Key('a', 100));
            keyList.Add(new Key('b', 200));
            bool ok = await FileWriter.SaveFile(keyList);

            // Create another keyList and read it from a file
            List<Key> keyList1;
            keyList1 = await FileWriter.ReadFile();

            bool expected = true;
            char expectedKey = 'b';
            double expectedTime = 200;
            bool expectedIsEnabled = true;

            Assert.AreEqual(expectedKey, keyList1[1].Button);
            Assert.AreEqual(expectedTime, keyList1[1].Time);
            Assert.AreEqual(expectedIsEnabled, keyList1[1].IsEnabled);
            Assert.AreEqual(expected, ok);
        }
    }
}
