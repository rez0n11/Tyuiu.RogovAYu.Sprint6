﻿namespace Tyuiu.RogovAYu.Sprint6.Task6.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("AucHJjziZ jiUFMDjMsEervIz ziwVyU", ds.calc());
        }
    }
}