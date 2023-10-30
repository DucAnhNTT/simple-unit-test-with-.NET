using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcualtorVS2019;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;

        [TestInitialize] //thiet lap du lieu dung chung cho TC
        public void setUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod] //TC1: a=10, b=5, kq=15 
        public void TestCong()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTru()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNhan()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestChia()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
