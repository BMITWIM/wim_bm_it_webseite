using NUnit.Framework;
using System;
using System.IO;
using ProjektRaumschiff;


{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         Raumschiffvorlage("test", 10)
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}