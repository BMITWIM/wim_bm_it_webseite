using NUnit.Framework;
using System;
using System.IO;
using ProjektRaumschiff;

namespace ProjektRaumschiff
{

    public class Tests
    {
        Raumschiffvorlage test = new Raumschiffvorlage();
        Raumschiffvorlage alba = new Raumschiffvorlage("alba", 10);
        Raumschiffvorlage duga = new Raumschiffvorlage("duga", 40);
            
        [SetUp]
        public void Setup()
        {
            

            Assert.AreEqual(test.getSchiffName(), "Enterprise");
            Assert.AreEqual(test.getSchiffgeschwindigkeit(), 100);
            Assert.AreEqual("alba", alba.getSchiffName() );
            Assert.AreEqual(10, alba.getSchiffgeschwindigkeit());
            Assert.AreEqual("duga", duga.getSchiffName());
            Assert.AreEqual(40, duga.getSchiffgeschwindigkeit());
            Assert.AreEqual(test.getLeben(), 50);
            Assert.AreEqual(alba.getLeben(), 50);
        }

        [Test]
        public void KollisionTest()
        {
            alba.Kollision();

            Assert.Less(alba.getLeben(), 50); ;
        }

        [Test]
        public void Game()
        {
            Game(alba, duga);

        }
    }
}