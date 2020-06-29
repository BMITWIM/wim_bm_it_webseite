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
            String sn = "alba";
            int sg = 10;
            Raumschiffvorlage alba = new Raumschiffvorlage("alba", 10);

            Assert.AreEqual(test.getSchiffName(), "Enterprise");
            Assert.AreEqual(test.getSchiffgeschwindigkeit(), 100);
            Assert.AreEqual("alba", alba.getSchiffName() );
            Assert.AreEqual(10, alba.getSchiffgeschwindigkeit());
        }

        [Test]
        public void ZeigeStautsTest()
        {
            
        }
    }
}