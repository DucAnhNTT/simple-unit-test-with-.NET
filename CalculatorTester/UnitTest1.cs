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

        [TestMethod] //TC2: a=10, b=5, kq=5
        public void TestTru()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNhan() //TC3: a=10, b=5, kq=50
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC4: a=10, b=5, kq=2 
        public void TestChia()
        {
            int expected, actual;
            //Calculation c = new Calculation(a,b);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod] //TC5: a=10, b=0, kq=DivideByZeroException
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\Data\DataTest_cotToantu.csv", "DataTest_cotToantu#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSourceAndOperation()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();          
            int expected = int.Parse(TestContext.DataRow[3].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation.Replace("'",""));
            Assert.AreEqual(expected, actual);
        }

    }
}
