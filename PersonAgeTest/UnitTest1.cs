using PersionAgeProgram;
using System;
using System.Text.RegularExpressions;

namespace PersonAgeTest
{
    [TestClass]
    public class CheckAge
    {
        Person p = new Person();

        [TestMethod]
        public void TestMethod1()
        {
            int age = 28;
            int actualAge = p.ValidAge(age);
            Assert.AreEqual(28, actualAge);
        }
    }
}