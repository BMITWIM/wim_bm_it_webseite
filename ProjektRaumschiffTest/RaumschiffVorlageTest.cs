using NUnit.Framework;
using System;
using System.IO;
using ProjektRaumschiff;

namespace ProjektRaumschiff
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Raumschiffvorlage test = new Raumschiffvorlage();
            Raumschiffvorlage alba = new Raumschiffvorlage("alba", 10);

            Assert.AreEqual(test.getSchiffName(), "Enterprise");
            Assert.AreEqual(test.getSchiffgeschwindigkeit(), 100);
            Assert.AreEqual(alba.getSchiffName(), "alba");
            Assert.AreEqual(alba.getSchiffgeschwindigkeit(), 10);
        }

        [Test]
        public void ZeigeStautsTest()
        {
            Assert.Pass();
        }
    }
}