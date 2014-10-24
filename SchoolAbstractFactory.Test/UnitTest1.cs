using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolAbstractFactory.Lib;

namespace SchoolAbstractFactory.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJensenFactory()
        {
            //ARRANGE
            string expected = "Jensen";

            //ACT
            IEducation actual = new JensenFactory().CreateEducation();

            //ASSERT
            Assert.AreEqual(expected, actual.EducationName);
        }

        [TestMethod]
        public void TestNackademinFactory()
        {
            //ARRANGE
            string expected = "Nackademin";

            //ACT
            IEducation actual = new NackademinFactory().CreateEducation();

            //ASSERT
            Assert.AreEqual(expected, actual.EducationName);
        }
    }
}
